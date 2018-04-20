import * as ko from 'knockout';

class JsFiddleViewModel {


	public stringPage = ko.observable("");
	public html = ko.observable("");
	public js = ko.observable("");
	public css = ko.observable("");
	public result = ko.observable("");

	public createResult() {
		let css = "<style>" + this.css() + "</style>";
		let js = "<script>" + this.js() + "</script";
		let result = "<html><head>" + css + "</head><body>" + this.html() + js + "</body></html>";
		this.stringPage(result);
	}

}

export default { viewModel: JsFiddleViewModel, template: require('./jsfiddle.html') };
