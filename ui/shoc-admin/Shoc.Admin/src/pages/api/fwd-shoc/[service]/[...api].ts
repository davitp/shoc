import { auth } from "@/addons/auth";
import { getJwtNode } from "@/addons/auth/actions";
import { decodeJwt } from "@/addons/oauth2/utils";
import httpProxy from "http-proxy";
import { NextApiRequest, NextApiResponse, PageConfig } from "next";

export const config: PageConfig = {
  api: {
    externalResolver: true,
    bodyParser: false,
  },
};


export default async function handle(req: NextApiRequest, res: NextApiResponse) {

  await auth(req, res);
  
  const jwt = await getJwtNode(req.headers);
  if(jwt?.actualAccessToken){

    const decoded = decodeJwt(jwt.actualAccessToken);
    const expirationDate = new Date(decoded.exp * 1000);
    const expired = expirationDate.getTime() < new Date().getTime()
    console.log(`Latest token used: SID: ${jwt.sid}, JTI: ${decoded.jti}, Expired: ${expired}, Expiration: ${expirationDate}`)
}
  const proxy: httpProxy = httpProxy.createProxy();

  let apiRoot = process.env.SHOC_ADMIN_API_ROOT || '';
  if (apiRoot.endsWith('/')) {
    apiRoot = apiRoot.replace(/\/$/, "");
  }

  req.url = req.url?.replace('/api/fwd-shoc', '');

  proxy.web(req, res, {
    changeOrigin: true,
    target: apiRoot,
    secure: process.env.NODE_TLS_REJECT_UNAUTHORIZED !== '0',
    headers: {
      'Authorization': `Bearer ${jwt?.actualAccessToken || ''}`,
      'Cookie': ''
    }
  }, () => { });
}