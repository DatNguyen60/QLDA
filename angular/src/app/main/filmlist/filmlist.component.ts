import { Component, Injector } from '@angular/core';
import { AppComponentBase } from '@shared/common/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { ApiService } from '../api.service';
@Component({
    templateUrl: './filmlist.component.html',
    animations: [appModuleAnimation()]
})

export class FilmListComponent extends AppComponentBase {
    data: any;
    filter: string = '';
    constructor(
        injector: Injector,
        private apiService: ApiService
    ) {
        super(injector);
    }
    ngOnInit(): void {
        this.apiService.fetchFilmListData().subscribe((response) => {
          this.data = response.result.items;
          console.log(response);
        });
    }

}