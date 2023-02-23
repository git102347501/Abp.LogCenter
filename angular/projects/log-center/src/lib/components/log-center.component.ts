import { Component, OnInit } from '@angular/core';
import { LogCenterService } from '../services/log-center.service';

@Component({
  selector: 'lib-log-center',
  template: ` <p>log-center works!</p> `,
  styles: [],
})
export class LogCenterComponent implements OnInit {
  constructor(private service: LogCenterService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}
