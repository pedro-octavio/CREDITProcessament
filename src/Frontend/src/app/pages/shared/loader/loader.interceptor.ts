import { HttpEvent, HttpHandler, HttpInterceptor, HttpRequest } from '@angular/common/http'

import { Observable } from 'rxjs'
import { finalize } from 'rxjs/operators'

import { LoaderService } from './loader.service'

export class LoaderInterceptor implements HttpInterceptor {
    constructor(public loaderService: LoaderService) {

    }

    intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
        this.loaderService.show()

        return next.handle(req).pipe(finalize(() => this.loaderService.hide()))
    }
}
