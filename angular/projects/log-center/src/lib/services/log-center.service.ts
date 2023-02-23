import { Injectable } from '@angular/core';
import { RestService } from '@abp/ng.core';

@Injectable({
  providedIn: 'root',
})
export class LogCenterService {
  apiName = 'LogCenter';

  constructor(private restService: RestService) {}

  sample() {
    return this.restService.request<void, any>(
      { method: 'GET', url: '/api/LogCenter/sample' },
      { apiName: this.apiName }
    );
  }
}
