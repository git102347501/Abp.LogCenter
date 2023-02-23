import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { LogCenterComponent } from './components/log-center.component';
import { LogCenterRoutingModule } from './log-center-routing.module';

@NgModule({
  declarations: [LogCenterComponent],
  imports: [CoreModule, ThemeSharedModule, LogCenterRoutingModule],
  exports: [LogCenterComponent],
})
export class LogCenterModule {
  static forChild(): ModuleWithProviders<LogCenterModule> {
    return {
      ngModule: LogCenterModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<LogCenterModule> {
    return new LazyModuleFactory(LogCenterModule.forChild());
  }
}
