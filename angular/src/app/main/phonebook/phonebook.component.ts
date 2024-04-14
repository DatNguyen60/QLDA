import { Component, Injector } from '@angular/core';
import { AppComponentBase } from '@shared/common/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { ApiService } from '../api.service';
@Component({
    templateUrl: './phonebook.component.html',
    animations: [appModuleAnimation()]
})

export class PhoneBookComponent extends AppComponentBase {
    data: any;
    constructor(
        injector: Injector,
        private apiService: ApiService
    ) {
        super(injector);
    }
    ngOnInit(): void {
        this.apiService.fetchPhoneBookData().subscribe((response) => {
          this.data = response.result.items;
          console.log(response);
        });
      }
    sayHello(): void{
        console.log("Hello world!");
    }
}
