import { Component } from '@angular/core';
import { BreakpointObserver, Breakpoints } from '@angular/cdk/layout';
import { Observable } from 'rxjs';
import { map, shareReplay } from 'rxjs/operators';
import { NavMenuItem } from 'src/app/models/models';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent {
  menu = [
    { Label: 'Dashboard', Target: '/dashboard' },
    { Label: 'Patients', Target: '/patients' },
    { Label: 'Doctors', Target: '/doctors' },
    { Label: 'Table', Target: '/table' },
    { Label: 'Counter', Target: '/counter' },
    { Label: 'Fetch data', Target: '/fetch-data' },
    { Label: 'Tasks', Target: '/todo' }
    ] as NavMenuItem[];

  isHandset$: Observable<boolean> = this.breakpointObserver.observe(Breakpoints.Handset)
    .pipe(
      map(result => result.matches),
      shareReplay()
    );

  constructor(private breakpointObserver: BreakpointObserver) {}

}
