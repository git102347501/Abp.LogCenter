import { eLayoutType, RoutesService } from '@abp/ng.core';
import { APP_INITIALIZER } from '@angular/core';
import { eLogCenterRouteNames } from '../enums/route-names';

export const LOG_CENTER_ROUTE_PROVIDERS = [
  {
    provide: APP_INITIALIZER,
    useFactory: configureRoutes,
    deps: [RoutesService],
    multi: true,
  },
];

export function configureRoutes(routesService: RoutesService) {
  return () => {
    routesService.add([
      {
        path: '/log-center',
        name: eLogCenterRouteNames.LogCenter,
        iconClass: 'fas fa-book',
        layout: eLayoutType.application,
        order: 3,
      },
    ]);
  };
}
