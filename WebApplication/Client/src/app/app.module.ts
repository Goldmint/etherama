import { NgModule } from '@angular/core';
import { BrowserModule, Title } from '@angular/platform-browser';
import { HttpClient, HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { AppRouting } from './app.routing';

import { APIHttpInterceptor } from './common/api/api-http.interceptor';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';

import { TranslateModule, TranslateLoader } from '@ngx-translate/core';
import { TranslateHttpLoader } from '@ngx-translate/http-loader';
import { registerLocaleData } from '@angular/common';
import localeRu from '@angular/common/locales/ru';
registerLocaleData(localeRu);
import { RECAPTCHA_SETTINGS,
  RecaptchaModule
} from 'ng-recaptcha';

import {
  BsDropdownModule,
  ModalModule,
  ButtonsModule, CollapseModule, PopoverModule
} from 'ngx-bootstrap';

import { HeaderBlockComponent } from './blocks/header-block/header-block.component';
import { NavbarBlockComponent } from './blocks/navbar-block/navbar-block.component';
import { MessageBoxComponent } from './common/message-box/message-box.component';
import { SpriteComponent } from './common/sprite/sprite.component';
import {EthereumService} from "./services/ethereum.service";
import {BrowserAnimationsModule} from "@angular/platform-browser/animations";
import {MessageBoxService} from "./services/message-box.service";
import {APIService} from "./services/api.service";
import {NotFoundPageComponent} from "./components/not-found-page/not-found-page.component";
import {LanguageSwitcherBlockComponent} from "./blocks/language-switcher-block/language-switcher-block.component";
import {UserService} from "./services/user.service";
import {BuyComponent} from "./components/trade/buy/buy.component";
import {SellComponent} from "./components/trade/sell/sell.component";
import {SubstrPipe} from "./pipes/substr.pipe";
import {NoexpPipe} from "./pipes/noexp.pipe";
import { PromoBonusComponent } from './components/trade/promo-bonus/promo-bonus.component';
import { AddTokenComponent } from './components/add-token/add-token.component';
import { TimerComponent } from './common/timer/timer.component';
import { StatisticChartsComponent } from './components/trade/statistic-charts/statistic-charts.component';
import { BuySellModalComponent } from './common/buy-sell-modal/buy-sell-modal.component';
import { AboutComponent } from './components/about/about.component';
import { FaqComponent } from './components/faq/faq.component';
import { MarketComponent } from './components/market/market.component';
import { TradeComponent } from './components/trade/trade.component';
import {CommonService} from "./services/common.service";
import { EthAddressValidatorDirective } from './directives/eth-address-validator.directive';
import {environment} from "../environments/environment";

export function createTranslateLoader(http: HttpClient) {
    return new TranslateHttpLoader(http, './assets/i18n/', '.json');
}

@NgModule({
  imports: [
    AppRouting,
    HttpClientModule,
    BrowserModule,
    FormsModule,
    BrowserAnimationsModule,
    ReactiveFormsModule,
    BsDropdownModule.forRoot(),
    ModalModule.forRoot(),
    ButtonsModule.forRoot(),
    CollapseModule.forRoot(),
    RecaptchaModule.forRoot(),
    HttpClientModule,
    NgxDatatableModule,
    PopoverModule.forRoot(),
    TranslateModule.forRoot({
      loader: {
        provide: TranslateLoader,
        useFactory: createTranslateLoader,
        deps: [HttpClient]
      }
    })
  ],
  declarations: [
    AppComponent,
    LanguageSwitcherBlockComponent,
    HeaderBlockComponent,
    NavbarBlockComponent,
    MessageBoxComponent,
    SpriteComponent,
    NotFoundPageComponent,
    BuyComponent,
    SellComponent,
    SubstrPipe,
    NoexpPipe,
    PromoBonusComponent,
    AddTokenComponent,
    TimerComponent,
    StatisticChartsComponent,
    BuySellModalComponent,
    AboutComponent,
    FaqComponent,
    MarketComponent,
    TradeComponent,
    EthAddressValidatorDirective
  ],
  exports: [],
  providers: [
    Title,
    MessageBoxService,
    APIService,
    UserService,
    CommonService,
    EthereumService,
    {
      provide: RECAPTCHA_SETTINGS,
      useValue: {
        siteKey: environment.recaptchaSiteKey
      }
    },
    {
      provide: HTTP_INTERCEPTORS,
      useClass: APIHttpInterceptor,
      multi: true
    }
  ],
  entryComponents: [
    MessageBoxComponent,
    BuySellModalComponent
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
