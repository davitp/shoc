import BaseAxiosClient from "@/clients/base-axios-client";

/**
 * The client for "identity" applications service
 */
export default class ApplicationsClient extends BaseAxiosClient {
  /**
   * Creates new instance of the client
   *
   * @param {*} config The client configuration
   */
  constructor(config) {
    super("shoc-identity", config);
  }


  getAll(token) {

    const url = this.urlify({
      api: "api/applications"
    });

    return this.webClient.get(url, {
      headers: {
        ...this.authBearer(token)
      }
    });
  }

  getById(token, id) {

    const url = this.urlify({
      api: `api/applications/${id}`
    });

    return this.webClient.get(url, {
      headers: {
        ...this.authBearer(token)
      }
    });
  }

  create(token, input) {

    const url = this.urlify({
      api: `api/applications`,
    });

    return this.webClient.post(url, input, {
      headers: {
        ...this.authBearer(token)
      }
    });
  }

  updateById(token, id, input) {

    const url = this.urlify({
      api: `api/applications/${id}`,
    });

    return this.webClient.put(url, input, {
      headers: {
        ...this.authBearer(token)
      }
    });
  }

  deleteById(token, id) {

    const url = this.urlify({
      api: `api/applications/${id}`,
    });

    return this.webClient.delete(url, {
      headers: {
        ...this.authBearer(token)
      }
    });
  }
}
