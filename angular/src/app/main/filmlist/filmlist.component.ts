import { Component, Injector } from '@angular/core';
import { AppComponentBase } from '@shared/common/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { ApiService } from '../api.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
@Component({
    templateUrl: './filmlist.component.html',
    animations: [appModuleAnimation()]
})

export class FilmListComponent extends AppComponentBase {
    data: any;
    filter: string = '';
    constructor(
        injector: Injector,
        private apiService: ApiService,
        private fb: FormBuilder
    ) {
        super(injector);
    }

    ngOnInit(): void {
        this.apiService.fetchFilmListData().subscribe((response) => {
          this.data = response.result.items;
          console.log(response);
        });
    }
    ShowAddPopup(){
       document.getElementById("addPopup").classList.toggle("d-none"); 
    }
    AddFilm():void{
        this.checkValue();
        const filmNameInput = document.getElementById("filmName") as HTMLInputElement;
        const description = document.getElementById("description") as HTMLInputElement;
        const pictureLink = document.getElementById("pictureLink") as HTMLInputElement;
        const price = document.getElementById("price") as HTMLInputElement;

        var filmData = {
            name : filmNameInput.value,
            description : description.value,
            pictureLink : pictureLink.value,
            price : price.value
        }
        this.apiService.addFilm(filmData).subscribe({
            next: () => {
              console.log('Phim đã được thêm thành công.');
              // Thực hiện các hành động khác nếu cần, ví dụ: thông báo cho người dùng
            },
            error: (err) => {
              console.error('Có lỗi xảy ra khi thêm phim:', err);
              // Xử lý lỗi, ví dụ: thông báo lỗi cho người dùng
            }
          });
      
    }
    DeleteFilm(filmId:any):void{
        console.log(filmId);
        this.apiService.deleteFilm(filmId).subscribe({
            next: () => {
              console.log('Phim đã được xóa thành công.');
              // Thực hiện các hành động khác nếu cần, ví dụ: thông báo cho người dùng
            },
            error: (err) => {
              console.error('Có lỗi xảy ra khi xóa phim:', err);
              // Xử lý lỗi, ví dụ: thông báo lỗi cho người dùng
            }
          });
    }
    checkValue():void{
        const filmNameInput = document.getElementById("filmName") as HTMLInputElement;

        // Kiểm tra nếu phần tử tồn tại
        if (filmNameInput) {
        // Lấy giá trị của input
        const filmNameValue = filmNameInput.value;
        console.log(filmNameValue);
        } else {
        console.error("Không tìm thấy phần tử với id 'filmName'");
        }
        
    }

}