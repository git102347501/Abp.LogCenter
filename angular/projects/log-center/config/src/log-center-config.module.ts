import { ModuleWithProviders, NgModule } from '@angular/core';
import { LOG_CENTER_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class LogCenterConfigModule {
  static forRoot(): ModuleWithProviders<LogCenterConfigModule> {
    return {
      ngModule: LogCenterConfigModule,
      providers: [LOG_CENTER_ROUTE_PROVIDERS],
    };
  }
}
