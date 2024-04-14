import {NgModule} from '@angular/core';
import {AppSharedModule} from '@app/shared/app-shared.module';
import {FilmListRoutingModule} from './filmlist-routing.module';
import {FilmListComponent} from './filmlist.component';

@NgModule({
    declarations: [FilmListComponent],
    imports: [AppSharedModule, FilmListRoutingModule]
})
export class FilmListModule {}