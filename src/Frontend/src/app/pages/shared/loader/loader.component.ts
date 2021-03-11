import { Component } from '@angular/core'

import { Subject } from 'rxjs'

import { LoaderService } from './loader.service'

@Component({
  selector: 'app-loader',
  templateUrl: './loader.component.html'
})

export class LoaderComponent {
  constructor(private loaderService: LoaderService) {

  }

  public loading: Subject<boolean> = this.loaderService.isLoading
}
