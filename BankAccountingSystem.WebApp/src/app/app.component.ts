import { Component, OnInit } from '@angular/core';

import { Http } from '@angular/http';
@Component({
    selector: 'app-root',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
    constructor(private _httpService: Http) { }
    title: string = "Sanjay";
    apiValues: string[] = [];
    requestOptions: any = {
        headers: { "Access-Control-Allow-Origin":"http://localhost:4200"}
    };
    ngOnInit() {
        this._httpService.get('http://localhost:5031/api/values', this.requestOptions).subscribe(values => {
        this.apiValues = values.json() as string[];
        });
    }
}
