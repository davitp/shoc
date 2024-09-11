import { selfClient } from "@/clients/shoc";
import RegistriesClient from "@/clients/shoc/registry/registries-client";
import StandardAlert from "@/components/general/standard-alert";
import { useApiAuthentication } from "@/providers/api-authentication/use-api-authentication";
import { maxDisplayNameLength, registryHostPattern, registryNamePattern, registryStatuses } from "@/well-known/registries";
import { Form, Input, Modal, Select } from "antd";
import { useEffect } from "react";
import { useState } from "react";

const formItemLayout = {
    labelCol: {
        xs: { span: 24 },
        sm: { span: 6 },
    },
    wrapperCol: {
        xs: { span: 24 },
        sm: { span: 18 },
    },
};

export default function RegistryUpdateModal(props: any) {

    const { onClose, onSuccess, existing = {}, open } = props;

    const [form] = Form.useForm();
    const { withToken } = useApiAuthentication();
    const [progress, setProgress] = useState(false);
    const [errors, setErrors] = useState([]);

    const onCloseWrapper = () => {

        setErrors([]);

        if (onClose) {
            onClose();
        }
    }

    const onSubmit = async (values: any) => {
        setErrors([]);
        setProgress(true);

        const result = await withToken((token: string) => selfClient(RegistriesClient).updateById(token, existing.id, { ...values }));

        setProgress(false);

        if (result.error) {
            setErrors(result.payload.errors);
            return;
        }

        if (onSuccess) {
            onSuccess(result.payload);
        }

        onCloseWrapper();
    }

    useEffect(() => {

        if (!open) {
            return;
        }

        form.setFieldsValue({
            ...existing
        });

    }, [form, existing, open])

    return (
        <Modal
            closable={false}
            cancelButtonProps={{ disabled: progress }}
            open={open}
            forceRender
            onCancel={onCloseWrapper}
            destroyOnClose={true}
            title="Update Registry"
            confirmLoading={progress}
            onOk={() => form.submit()}
        >
            <StandardAlert style={{ marginBottom: "8px" }} message="Could not update the registry" errors={errors} optional={true} />
            <Form form={form} onFinish={onSubmit} layout="horizontal" {...formItemLayout}>
            <Form.Item name="name" label="Name" rules={[
                    { required: true, message: 'Please enter valid name' },
                    { pattern: registryNamePattern, message: 'The name is invalid' }
                    ]}>
                    <Input placeholder="Please enter the name" />
                </Form.Item> 
                <Form.Item name="displayName" label="Display name" rules={[
                    { required: true, max: maxDisplayNameLength, message: 'Please enter valid display name' }
                    ]}>
                    <Input placeholder="Please enter a display name" />
                </Form.Item>         
                <Form.Item name="status" label="Status" rules={[{ required: true, message: 'Please select a valid status' }]}>
                    <Select placeholder="Select the status ">
                        {registryStatuses.map(entry => <Select.Option key={entry.key} value={entry.key}>{entry.display}</Select.Option>)}
                    </Select>
                </Form.Item>
                <Form.Item name="registry" label="Registry" rules={[
                    { required: true, max: maxDisplayNameLength, message: 'Please enter valid registry host' },
                    { pattern: registryHostPattern, message: 'The registry host is not valid' }
                    ]}>
                    <Input placeholder="Please enter a registry host" />
                </Form.Item>
                <Form.Item name="namespace" label="Namespace">
                    <Input placeholder="Please enter the namespace" />
                </Form.Item>     
            </Form>
        </Modal>
    );

}