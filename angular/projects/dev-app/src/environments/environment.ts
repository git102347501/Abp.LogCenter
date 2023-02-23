import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'LogCenter',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44378/',
    redirectUri: baseUrl,
    clientId: 'LogCenter_App',
    responseType: 'code',
    scope: 'offline_access LogCenter',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44378',
      rootNamespace: 'Abp.LogCenter',
    },
    LogCenter: {
      url: 'https://localhost:44307',
      rootNamespace: 'Abp.LogCenter',
    },
  },
} as Environment;
