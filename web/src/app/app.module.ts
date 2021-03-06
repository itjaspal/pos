import { CommonService } from './_service/common.service';
import { DropdownlistService } from './_service/dropdownlist.service';
import { NgModule, ApplicationRef } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import {
  MatAutocompleteModule,
  MatButtonModule,
  MatButtonToggleModule,
  MatCardModule,
  MatCheckboxModule,
  MatChipsModule,
  MatDatepickerModule,
  MatDialogModule,
  MatExpansionModule,
  MatGridListModule,
  MatIconModule,
  MatInputModule,
  MatListModule,
  MatMenuModule,
  MatNativeDateModule,
  MatPaginatorModule,
  MatProgressBarModule,
  MatProgressSpinnerModule,
  MatRadioModule,
  MatRippleModule,
  MatSelectModule,
  MatSidenavModule,
  MatSliderModule,
  MatSlideToggleModule,
  MatSnackBarModule,
  MatSortModule,
  MatTableModule,
  MatTabsModule,
  MatToolbarModule,
  MatTooltipModule,
  MatStepperModule,
  MAT_DATE_FORMATS,
  DateAdapter
} from '@angular/material';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
// Layout
import { LayoutComponent } from './layout/layout.component';
import { PreloaderDirective } from './layout/preloader.directive';
// Header
import { AppHeaderComponent } from './layout/header/header.component';
// Sidenav
import { AppSidenavComponent } from './layout/sidenav/sidenav.component';
import { ToggleOffcanvasNavDirective } from './layout/sidenav/toggle-offcanvas-nav.directive';
import { AutoCloseMobileNavDirective } from './layout/sidenav/auto-close-mobile-nav.directive';
import { AppSidenavMenuComponent } from './layout/sidenav/sidenav-menu/sidenav-menu.component';
import { AccordionNavDirective } from './layout/sidenav/sidenav-menu/accordion-nav.directive';
import { AppendSubmenuIconDirective } from './layout/sidenav/sidenav-menu/append-submenu-icon.directive';
import { HighlightActiveItemsDirective } from './layout/sidenav/sidenav-menu/highlight-active-items.directive';
// Customizer
import { AppCustomizerComponent } from './layout/customizer/customizer.component';
import { ToggleQuickviewDirective } from './layout/customizer/toggle-quickview.directive';
// Footer
import { AppFooterComponent } from './layout/footer/footer.component';
// Search Overaly
import { AppSearchOverlayComponent } from './layout/search-overlay/search-overlay.component';
import { SearchOverlayDirective } from './layout/search-overlay/search-overlay.directive';
import { OpenSearchOverlaylDirective } from './layout/search-overlay/open-search-overlay.directive';

// Sub modules
import { LayoutModule } from './layout/layout.module';
import { SharedModule } from './shared/shared.module';

//3rd party
import { NgxMatSelectSearchModule } from 'ngx-mat-select-search';
import { ZXingScannerModule } from '@zxing/ngx-scanner';
import { SignaturePadModule } from 'angular2-signaturepad';

// hmr
import { removeNgStyles, createNewHosts } from '@angularclass/hmr';
import { AppMobileFooterComponent } from './layout/mobile-footer/mobile-footer.component';
import { AppMobileHeaderComponent } from './layout/mobile-header/mobile-header.component';

//http interceptor
import { HTTP_INTERCEPTORS, HttpClient, HttpClientModule } from '@angular/common/http';
import { HttpModule } from '@angular/http';
import { TokenInterceptor } from './_service/token.interceptor';

import { CustomDateAdapter, APP_DATE_FORMATS } from './_common/custom-date-adapter';

// Pages

import { MobileMenuComponent } from './mobile-menu/mobile-menu.component';
import { UserLoginComponent } from './user-login/user-login.component';
import { BranchGroupSearchComponent } from './master-branch-group/branch-group-search/branch-group-search.component';
import { BranchGroupCreateComponent } from './master-branch-group/branch-group-create/branch-group-create.component';
import { BranchGroupUpdateComponent } from './master-branch-group/branch-group-update/branch-group-update.component';
import { BranchGroupViewComponent } from './master-branch-group/branch-group-view/branch-group-view.component';
import { DepartmentSearchComponent } from './master-department/department-search/department-search.component';
import { DepartmentCreateComponent } from './master-department/department-create/department-create.component';
import { DepartmentUpdateComponent } from './master-department/department-update/department-update.component';
import { DepartmentViewComponent } from './master-department/department-view/department-view.component';

//service

import { LoaderService } from './_service/loader.service';
import { BranchSearchComponent } from './master-branch/branch-search/branch-search.component';
import { BranchSaveComponent } from './master-branch/branch-save/branch-save.component';
import { BranchViewComponent } from './master-branch/branch-view/branch-view.component';
import { MobileProfileComponent } from './mobile-profile/mobile-profile.component';
import { InqUserComponent } from './master-user/inq/inq-user.component';
import { UserService } from './_service/user.service';
import { CreateUserComponent } from './master-user/create/create-user.component';
import { PopupMessageComponent } from './modal/message/popup-message.component';
import { MessageService } from './_service/message.service';
import { ViewUserComponent } from './master-user/view/view-user.component';
import { UpdateUserComponent } from './master-user/update/update-user.component';
import { DisableControlDirective } from './_directive/disable-control.component';
import { ResetPasswordUserComponent } from './master-user/reset-password/reset-user.component';
import { UserRoleService } from './_service/user-role.service';
import { InqUserRoleComponent } from './master-user-role/inq/inq-user-role.component';
import { CreateUserRoleComponent } from './master-user-role/create/create-user-role.component';
import { ViewUserRoleComponent } from './master-user-role/view/view-user-role.component';
import { UpdateUserRoleComponent } from './master-user-role/update/update-user-role.component';

import { ChangePasswordComponent } from './master-user/change-password/change-password.component';
import { HomeComponent } from './home/home.component';

import { ListFilterPipe } from './_pipe/list-filter.pipe';
import { HighlightPipe } from './_pipe/highlight.pipe';

import { ConfirmMessageComponent } from './modal/confirm-message/confirm-message.component';

import { BuilderFilterPipe } from './_pipe/array-filter.pipe';

import { MenuGroupCreateComponent } from './master-menu-group/menu-group-create/menu-group-create.component';
import { MenuGroupSearchComponent } from './master-menu-group/menu-group-search/menu-group-search.component';
import { MenuGroupUpdateComponent } from './master-menu-group/menu-group-update/menu-group-update.component';
import { MenuGroupViewComponent } from './master-menu-group/menu-group-view/menu-group-view.component';
import { MenuGroupService } from './_service/menu-group.service';
import { MenuCreateComponent } from './master-menu/menu-create/menu-create.component';
import { MenuSearchComponent } from './master-menu/menu-search/menu-search.component';
import { MenuUpdateComponent } from './master-menu/menu-update/menu-update.component';
import { MenuViewComponent } from './master-menu/menu-view/menu-view.component';
import { MenuService } from './_service/menu.service';
import { BranchSearchAssignProductComponent } from './master-branch/branch-search-assignProduct/branch-search-assignProduct.component';
import { MenuActionCreateComponent } from './master-menu-action/menu-action-create/menu-action-create.component';
import { MenuActionSearchComponent } from './master-menu-action/menu-action-search/menu-action-search.component';
import { MenuActionUpdateComponent } from './master-menu-action/menu-action-update/menu-action-update.component';
import { CustomerCreateComponent } from './customer/customer-create/customer-create.component';
import { CustomerSearchComponent } from './customer/customer-search/customer-search.component';
import { CustomerUpdateComponent } from './customer/customer-update/customer-update.component';
import { CustomerViewComponent } from './customer/customer-view/customer-view.component';
import { UserSelectBranchComponent } from './user-select-branch/user-select-branch/user-select-branch.component';
import { DocCreateComponent } from './master-doc/doc-create/doc-create.component';
import { DocViewComponent } from './master-doc/doc-view/doc-view.component';
import { DocUpdateComponent } from './master-doc/doc-update/doc-update.component';
import { DocSearchComponent } from './master-doc/doc-search/doc-search.component';
import { DocControlCreateComponent } from './master-doc-control/doc-control-create/doc-control-create.component';
import { DocControlSearchComponent } from './master-doc-control/doc-control-search/doc-control-search.component';
import { DocControlViewComponent } from './master-doc-control/doc-control-view/doc-control-view.component';
import { DocControlUpdateComponent } from './master-doc-control/doc-control-update/doc-control-update.component';
import { EntityCreateComponent } from './master-entity/entity-create/entity-create.component';
import { EntitySearchComponent } from './master-entity/entity-search/entity-search.component';
import { EntityViewComponent } from './master-entity/entity-view/entity-view.component';
import { EntityUpdateComponent } from './master-entity/entity-update/entity-update.component';
import { PaymentCreateComponent } from './master-payment/payment-create/payment-create.component';
import { PaymentSearchComponent } from './master-payment/payment-search/payment-search.component';
import { PaymentViewComponent } from './master-payment/payment-view/payment-view.component';
import { PaymentUpdateComponent } from './master-payment/payment-update/payment-update.component';
import { PosNoCreateComponent } from './master-pos-no/pos-no-create/pos-no-create.component';
import { PosNoSearchComponent } from './master-pos-no/pos-no-search/pos-no-search.component';
import { PosNoViewComponent } from './master-pos-no/pos-no-view/pos-no-view.component';
import { PosNoUpdateComponent } from './master-pos-no/pos-no-update/pos-no-update.component';
import { ProductCreateComponent } from './master-product/product-create/product-create.component';
import { ProductSearchComponent } from './master-product/product-search/product-search.component';
import { ProductViewComponent } from './master-product/product-view/product-view.component';
import { ProductUpdateComponent } from './master-product/product-update/product-update.component';
import { ProductNodiscCreateComponent } from './master-product-nodisc/product-nodisc-create/product-nodisc-create.component';
import { ProductNodiscSearchComponent } from './master-product-nodisc/product-nodisc-search/product-nodisc-search.component';
import { ProductNodiscViewComponent } from './master-product-nodisc/product-nodisc-view/product-nodisc-view.component';
import { ProductNodiscUpdateComponent } from './master-product-nodisc/product-nodisc-update/product-nodisc-update.component';
import { ProductPremiumCreateComponent } from './master-product-premium/product-premium-create/product-premium-create.component';
import { ProductPremiumSearchComponent } from './master-product-premium/product-premium-search/product-premium-search.component';
import { ProductPremiumViewComponent } from './master-product-premium/product-premium-view/product-premium-view.component';
import { ProductPremiumUpdateComponent } from './master-product-premium/product-premium-update/product-premium-update.component';
import { TaxCreateComponent } from './master-tax/tax-create/tax-create.component';
import { TaxSearchComponent } from './master-tax/tax-search/tax-search.component';
import { TaxViewComponent } from './master-tax/tax-view/tax-view.component';
import { TaxUpdateComponent } from './master-tax/tax-update/tax-update.component';
import { WarehouseCreateComponent } from './master-warehouse/warehouse-create/warehouse-create.component';
import { WarehouseSearchComponent } from './master-warehouse/warehouse-search/warehouse-search.component';
import { WarehouseViewComponent } from './master-warehouse/warehouse-view/warehouse-view.component';
import { WarehouseUpdateComponent } from './master-warehouse/warehouse-update/warehouse-update.component';







@NgModule({
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule.withConfig({ warnOnNgModelWithFormControl: 'never' }),
    BrowserAnimationsModule,
    MatAutocompleteModule,
    MatButtonModule,
    MatButtonToggleModule,
    MatCardModule,
    MatCheckboxModule,
    MatChipsModule,
    MatStepperModule,
    MatDatepickerModule,
    MatDialogModule,
    MatExpansionModule,
    MatGridListModule,
    MatIconModule,
    MatInputModule,
    MatListModule,
    MatMenuModule,
    MatNativeDateModule,
    MatPaginatorModule,
    MatProgressBarModule,
    MatProgressSpinnerModule,
    MatRadioModule,
    MatRippleModule,
    MatSelectModule,
    MatSidenavModule,
    MatSliderModule,
    MatSlideToggleModule,
    MatSnackBarModule,
    MatSortModule,
    MatTableModule,
    MatTabsModule,
    MatToolbarModule,
    MatTooltipModule,
    AppRoutingModule,
    NgbModule,

    // Sub modules
    LayoutModule,
    SharedModule,

    //3rd party
    NgxMatSelectSearchModule,
    ZXingScannerModule.forRoot(),
    SignaturePadModule,

  

    
  ],
  providers: [
    // AuthGuard,
    LoaderService,
    {
      provide: HTTP_INTERCEPTORS,
      useClass: TokenInterceptor,
      multi: true
    },
    {
      provide: DateAdapter, useClass: CustomDateAdapter
    },
    {
      provide: MAT_DATE_FORMATS, useValue: APP_DATE_FORMATS
    },


    //OrganizationService,
    DropdownlistService,
    UserService,
    UserRoleService,
    MessageService,
    CommonService,
   
    MenuGroupService,
    MenuService,
    // ColorFontService,
    // CatalogSizeService,
  

  ],
  declarations: [
    DisableControlDirective,
    AppComponent,
    // Layout
    LayoutComponent,
    PreloaderDirective,
    // Header
    AppHeaderComponent,
    AppMobileHeaderComponent,
    // Sidenav
    AppSidenavComponent,
    ToggleOffcanvasNavDirective,
    AutoCloseMobileNavDirective,
    AppSidenavMenuComponent,
    AccordionNavDirective,
    AppendSubmenuIconDirective,
    HighlightActiveItemsDirective,
    // Customizer
    AppCustomizerComponent,
    ToggleQuickviewDirective,
    // Footer
    AppFooterComponent,
    AppMobileFooterComponent,
    // Search overlay
    AppSearchOverlayComponent,
    SearchOverlayDirective,
    OpenSearchOverlaylDirective,
    // pipe
    ListFilterPipe,
    //
    
    MobileMenuComponent,
    MobileProfileComponent,
    UserLoginComponent,
    BranchGroupSearchComponent,
    BranchGroupCreateComponent,
    BranchGroupUpdateComponent,
    BranchGroupViewComponent,
    BranchSearchAssignProductComponent,
    DepartmentSearchComponent,
    DepartmentCreateComponent,
    DepartmentUpdateComponent,
    DepartmentViewComponent,
    BranchSearchComponent,
    BranchSaveComponent,
    BranchViewComponent,

    //User Component
    InqUserComponent,
    CreateUserComponent,
    ViewUserComponent,
    UpdateUserComponent,
    ResetPasswordUserComponent,
    ChangePasswordComponent,

    //User Role Component
    InqUserRoleComponent,
    CreateUserRoleComponent,
    ViewUserRoleComponent,
    UpdateUserRoleComponent,

    
    PopupMessageComponent,
    ConfirmMessageComponent,
    
    HomeComponent,

    
    ListFilterPipe,

    
    HighlightPipe,

    

    BuilderFilterPipe,
    
    
    MenuGroupCreateComponent,
    MenuGroupSearchComponent,
    MenuGroupUpdateComponent,
    MenuGroupViewComponent,
    MenuCreateComponent,
    MenuSearchComponent,
    MenuUpdateComponent,
    MenuViewComponent,
    MenuActionCreateComponent,
    MenuActionSearchComponent,
    MenuActionUpdateComponent,
    CustomerCreateComponent,
    CustomerSearchComponent,
    CustomerUpdateComponent,
    CustomerViewComponent,
    UserSelectBranchComponent,
    DocCreateComponent,
    DocViewComponent,
    DocUpdateComponent,
    DocSearchComponent,
    DocControlCreateComponent,
    DocControlSearchComponent,
    DocControlViewComponent,
    DocControlUpdateComponent,
    EntityCreateComponent,
    EntitySearchComponent,
    EntityViewComponent,
    EntityUpdateComponent,
    PaymentCreateComponent,
    PaymentSearchComponent,
    PaymentViewComponent,
    PaymentUpdateComponent,
    PosNoCreateComponent,
    PosNoSearchComponent,
    PosNoViewComponent,
    PosNoUpdateComponent,
    ProductCreateComponent,
    ProductSearchComponent,
    ProductViewComponent,
    ProductUpdateComponent,
    ProductNodiscCreateComponent,
    ProductNodiscSearchComponent,
    ProductNodiscViewComponent,
    ProductNodiscUpdateComponent,
    ProductPremiumCreateComponent,
    ProductPremiumSearchComponent,
    ProductPremiumViewComponent,
    ProductPremiumUpdateComponent,
    TaxCreateComponent,
    TaxSearchComponent,
    TaxViewComponent,
    TaxUpdateComponent,
    WarehouseCreateComponent,
    WarehouseSearchComponent,
    WarehouseViewComponent,
    WarehouseUpdateComponent,
    


  ],
  entryComponents: [
    PopupMessageComponent,
    ConfirmMessageComponent,
    
  ],
  bootstrap: [AppComponent]
})

export class AppModule {
  constructor(public appRef: ApplicationRef) { }
  hmrOnInit(store) {
    console.log('HMR store', store);
  }
  hmrOnDestroy(store) {
    const cmpLocation = this.appRef.components.map((cmp) => cmp.location.nativeElement);
    // recreate elements
    store.disposeOldHosts = createNewHosts(cmpLocation);
    // remove styles
    removeNgStyles();
  }
  hmrAfterDestroy(store) {
    // display new elements
    store.disposeOldHosts();
    delete store.disposeOldHosts;
  }
}
