import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeroComponent } from './shared/components/hero/hero.component';
import { PortfolioComponent } from './shared/components/portfolio/portfolio.component';
import { ContactComponent } from './shared/components/contact/contact.component';
import { WorkComponent } from './modules/home/pages/work/work.component';
import { CareersComponent } from './modules/home/pages/careers/careers.component';
import { DomainComponent } from './modules/home/pages/domain/domain.component';
import { CompanyComponent } from './modules/home/pages/company/company.component';
import { HeaderComponent } from './core/header/header.component';
import { FooterComponent } from './core/footer/footer.component';
import { MainHeaderComponent } from './core/main-header/main-header.component';
import { AlertModule } from 'ngx-bootstrap';

@NgModule({
  declarations: [
    AppComponent,
    HeroComponent,
    PortfolioComponent,
    ContactComponent,
    WorkComponent,
    CareersComponent,
    DomainComponent,
    CompanyComponent,
    HeaderComponent,
    FooterComponent,
    MainHeaderComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    AlertModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
