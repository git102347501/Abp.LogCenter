import { TestBed } from '@angular/core/testing';
import { LogCenterService } from './services/log-center.service';
import { RestService } from '@abp/ng.core';

describe('LogCenterService', () => {
  let service: LogCenterService;
  const mockRestService = jasmine.createSpyObj('RestService', ['request']);
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [
        {
          provide: RestService,
          useValue: mockRestService,
        },
      ],
    });
    service = TestBed.inject(LogCenterService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
