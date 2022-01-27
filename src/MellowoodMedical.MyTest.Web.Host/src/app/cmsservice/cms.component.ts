import { Component, Injector, ViewChild } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { CMSServiceServiceProxy, ListResultDtoOfGetContentListDto, Content } from '@shared/service-proxies/service-proxies';
import { PagedListingComponentBase, PagedRequestDto } from 'shared/paged-listing-component-base';


@Component({
    templateUrl: './cms.component.html',
    animations: [appModuleAnimation()]
})
export class CMSComponent extends PagedListingComponentBase<Content> {
    protected delete(entity: Content): void {
        throw new Error("Method not implemented.");
    }

    pageName: string = "Test";
    active: boolean = false;
    contents: Content[] = [];
    includeCanceledEvents: boolean = false;

    constructor(
        injector: Injector,
        private _cmsService: CMSServiceServiceProxy
    ) {
        super(injector);
    }

    protected list(request: PagedRequestDto, pageNumber: number, finishedCallback: Function): void {
        this.loadEvent();
        finishedCallback();
    }

    loadEvent() {
        this._cmsService.getAll()
            .subscribe((result: ListResultDtoOfGetContentListDto) => {
                this.contents = result.items;
            });
    }
}