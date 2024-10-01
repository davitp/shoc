import { NextResponse } from 'next/server';
import { shocClient } from '@/clients/shoc';
import PackageSchemasClient from '@/clients/shoc/package/package-schemas-client';
import axios from 'axios';
import ErrorDefinitions from '@/addons/error-handling/error-definitions';

export async function GET() {

    try {
        const response = await shocClient(PackageSchemasClient).getAll();
    
        return NextResponse.json(response.data);
      } catch (error) {

        if (axios.isAxiosError(error) && error.response) {
            return NextResponse.json(error.response.data, { status: error.response.status });
        }

        return NextResponse.json(
          { errors: ErrorDefinitions.unknown('Unexpected error from the server') },
          { status: 500 }
        );
      }
}