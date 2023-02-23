import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';
import { LogCenterComponent } from './components/log-center.component';
import { LogCenterService } from '@abp/log-center';
import { of } from 'rxjs';

describe('LogCenterComponent', () => {
  let component: LogCenterComponent;
  let fixture: ComponentFixture<LogCenterComponent>;
  const mockLogCenterService = jasmine.createSpyObj('LogCenterService', {
    sample: of([]),
  });
  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [LogCenterComponent],
      providers: [
        {
          provide: LogCenterService,
          useValue: mockLogCenterService,
        },
      ],
    }).compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LogCenterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
