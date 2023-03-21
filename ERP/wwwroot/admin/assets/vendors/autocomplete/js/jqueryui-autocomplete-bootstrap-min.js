﻿!function (s) { var i = {}; function o(t) { if (i[t]) return i[t].exports; var e = i[t] = { i: t, l: !1, exports: {} }; return s[t].call(e.exports, e, e.exports, o), e.l = !0, e.exports } o.m = s, o.c = i, o.d = function (t, e, s) { o.o(t, e) || Object.defineProperty(t, e, { enumerable: !0, get: s }) }, o.r = function (t) { "undefined" != typeof Symbol && Symbol.toStringTag && Object.defineProperty(t, Symbol.toStringTag, { value: "Module" }), Object.defineProperty(t, "__esModule", { value: !0 }) }, o.t = function (e, t) { if (1 & t && (e = o(e)), 8 & t) return e; if (4 & t && "object" == typeof e && e && e.__esModule) return e; var s = Object.create(null); if (o.r(s), Object.defineProperty(s, "default", { enumerable: !0, value: e }), 2 & t && "string" != typeof e) for (var i in e) o.d(s, i, function (t) { return e[t] }.bind(null, i)); return s }, o.n = function (t) { var e = t && t.__esModule ? function () { return t.default } : function () { return t }; return o.d(e, "a", e), e }, o.o = function (t, e) { return Object.prototype.hasOwnProperty.call(t, e) }, o.p = "", o(o.s = 0) }([function (t, e, s) { "use strict"; s.r(e), s.d(e, "AutoComplete", function () { return d }); var i, o, n, r = (i = function (t, e) { return (i = Object.setPrototypeOf || { __proto__: [] } instanceof Array && function (t, e) { t.__proto__ = e } || function (t, e) { for (var s in e) e.hasOwnProperty(s) && (t[s] = e[s]) })(t, e) }, function (t, e) { function s() { this.constructor = t } i(t, e), t.prototype = null === e ? Object.create(e) : (s.prototype = e.prototype, new s) }), l = (_.prototype.getDefaults = function () { return {} }, _.prototype.getResults = function (t, e, s) { return this.results }, _.prototype.search = function (t, e) { e(this.getResults()) }, r(p, o = _), p.prototype.getDefaults = function () { return { url: "", method: "get", queryKey: "q", extraData: {}, timeout: void 0, requestThrottling: 500 } }, p.prototype.search = function (t, e) { var s = this; null != this.jqXHR && this.jqXHR.abort(); var i = {}; i[this._settings.queryKey] = t, $.extend(i, this._settings.extraData), this.requestTID && window.clearTimeout(this.requestTID), this.requestTID = window.setTimeout(function () { s.jqXHR = $.ajax(s._settings.url, { method: s._settings.method, data: i, timeout: s._settings.timeout }), s.jqXHR.done(function (t) { e(t) }), s.jqXHR.fail(function (t) { var e; null === (e = s._settings) || void 0 === e || e.fail(t) }), s.jqXHR.always(function () { s.jqXHR = null }) }, this._settings.requestThrottling) }, p), a = (f.prototype.init = function () { var s = this, t = $.extend({}, this._$el.position(), { height: this._$el[0].offsetHeight }); this._dd = $("<ul />"), this._dd.addClass("bootstrap-autocomplete dropdown-menu"), this._dd.insertAfter(this._$el), this._dd.css({ top: t.top + this._$el.outerHeight(), left: t.left, width: this._$el.outerWidth() }), this._dd.on("click", "li", function (t) { var e = $(t.currentTarget).data("item"); s.itemSelectedLaunchEvent(e) }), this._dd.on("keyup", function (t) { if (s.shown) { switch (t.which) { case 27: s.hide(), s._$el.focus() }return !1 } }), this._dd.on("mouseenter", function (t) { s.ddMouseover = !0 }), this._dd.on("mouseleave", function (t) { s.ddMouseover = !1 }), this._dd.on("mouseenter", "li", function (t) { s.haveResults && ($(t.currentTarget).closest("ul").find("li.active").removeClass("active"), $(t.currentTarget).addClass("active"), s.mouseover = !0) }), this._dd.on("mouseleave", "li", function (t) { s.mouseover = !1 }), this.initialized = !0 }, f.prototype.checkInitialized = function () { this.initialized || this.init() }, Object.defineProperty(f.prototype, "isMouseOver", { get: function () { return this.mouseover }, enumerable: !1, configurable: !0 }), Object.defineProperty(f.prototype, "isDdMouseOver", { get: function () { return this.ddMouseover }, enumerable: !1, configurable: !0 }), Object.defineProperty(f.prototype, "haveResults", { get: function () { return 0 < this.items.length }, enumerable: !1, configurable: !0 }), f.prototype.focusNextItem = function (t) { var e, s; this.haveResults && (e = this._dd.find("li.active"), 0 === (s = t ? e.prev() : e.next()).length && (s = t ? this._dd.find("li").last() : this._dd.find("li").first()), e.removeClass("active"), s.addClass("active")) }, f.prototype.focusPreviousItem = function () { this.focusNextItem(!0) }, f.prototype.selectFocusItem = function () { this._dd.find("li.active").trigger("click") }, Object.defineProperty(f.prototype, "isItemFocused", { get: function () { return !!(this.isShown() && 0 < this._dd.find("li.active").length) }, enumerable: !1, configurable: !0 }), f.prototype.show = function () { this.shown || (this._dd.dropdown().show(), this.shown = !0) }, f.prototype.isShown = function () { return this.shown }, f.prototype.hide = function () { this.shown && (this._dd.dropdown().hide(), this.shown = !1) }, f.prototype.updateItems = function (t, e) { this.items = t, this.searchText = e, this.refreshItemList() }, f.prototype.showMatchedText = function (t, e) { var s = t.toLowerCase().indexOf(e.toLowerCase()); if (-1 < s) { var i = s + e.length; return t.slice(0, s) + "<b>" + t.slice(s, i) + "</b>" + t.slice(i) } return t }, f.prototype.refreshItemList = function () { var r = this; this.checkInitialized(), this._dd.empty(); var t, l = []; 0 < this.items.length ? this.items.forEach(function (t) { var e, s, i = r.formatItem(t); "string" == typeof i && (i = { text: i }), e = r.showMatchedText(i.text, r.searchText), s = void 0 !== i.html ? i.html : e; var o = i.disabled, n = $("<li >"); n.append($("<a>").attr("href", "#!").html(s)).data("item", t), o && n.addClass("disabled"), l.push(n) }) : ((t = $("<li >")).append($("<a>").attr("href", "#!").html(this.noResultsText)).addClass("disabled"), l.push(t)), this._dd.append(l) }, f.prototype.itemSelectedLaunchEvent = function (t) { this._$el.trigger("autocomplete.select", t) }, f), h = (c.prototype.getElPos = function () { return $.extend({}, this._$el.position(), { height: this._$el[0].offsetHeight }) }, c.prototype.init = function () { var s = this, t = this.getElPos(); this._dd = $("<div />"), this._dd.addClass("bootstrap-autocomplete dropdown-menu"), this._dd.insertAfter(this._$el), this._dd.css({ top: t.top + this._$el.outerHeight(), left: t.left, width: this._$el.outerWidth() }), this._dd.on("click", ".dropdown-item", function (t) { var e = $(t.currentTarget).data("item"); s.itemSelectedLaunchEvent(e), t.preventDefault() }), this._dd.on("keyup", function (t) { if (s.shown) { switch (t.which) { case 27: s.hide(), s._$el.focus() }return !1 } }), this._dd.on("mouseenter", function (t) { s.ddMouseover = !0 }), this._dd.on("mouseleave", function (t) { s.ddMouseover = !1 }), this._dd.on("mouseenter", ".dropdown-item", function (t) { s.haveResults && ($(t.currentTarget).closest("div").find(".dropdown-item.active").removeClass("active"), $(t.currentTarget).addClass("active"), s.mouseover = !0) }), this._dd.on("mouseleave", ".dropdown-item", function (t) { s.mouseover = !1 }), this.initialized = !0 }, c.prototype.checkInitialized = function () { this.initialized || this.init() }, Object.defineProperty(c.prototype, "isMouseOver", { get: function () { return this.mouseover }, enumerable: !1, configurable: !0 }), Object.defineProperty(c.prototype, "isDdMouseOver", { get: function () { return this.ddMouseover }, enumerable: !1, configurable: !0 }), Object.defineProperty(c.prototype, "haveResults", { get: function () { return 0 < this.items.length }, enumerable: !1, configurable: !0 }), c.prototype.focusNextItem = function (t) { var e, s; this.haveResults && (e = this._dd.find(".dropdown-item.active"), 0 === (s = t ? e.prev() : e.next()).length && (s = t ? this._dd.find(".dropdown-item").last() : this._dd.find(".dropdown-item").first()), e.removeClass("active"), s.addClass("active")) }, c.prototype.focusPreviousItem = function () { this.focusNextItem(!0) }, c.prototype.selectFocusItem = function () { this._dd.find(".dropdown-item.active").trigger("click") }, Object.defineProperty(c.prototype, "isItemFocused", { get: function () { return !!(this._dd && this.isShown() && 0 < this._dd.find(".dropdown-item.active").length) }, enumerable: !1, configurable: !0 }), c.prototype.show = function () { this.shown || (this.getElPos(), this._dd.addClass("show"), this.shown = !0, this._$el.trigger("autocomplete.dd.shown")) }, c.prototype.isShown = function () { return this.shown }, c.prototype.hide = function () { this.shown && (this._dd.removeClass("show"), this.shown = !1, this._$el.trigger("autocomplete.dd.hidden")) }, c.prototype.updateItems = function (t, e) { this.items = t, this.searchText = e, this.refreshItemList() }, c.prototype.showMatchedText = function (t, e) { var s = t.toLowerCase().indexOf(e.toLowerCase()); if (-1 < s) { var i = s + e.length; return t.slice(0, s) + "<b>" + t.slice(s, i) + "</b>" + t.slice(i) } return t }, c.prototype.refreshItemList = function () { var r = this; this.checkInitialized(), this._dd.empty(); var t, l = []; 0 < this.items.length ? (this.items.forEach(function (t) { var e, s, i = r.formatItem(t); "string" == typeof i && (i = { text: i }), e = r.showMatchedText(i.text, r.searchText), s = void 0 !== i.html ? i.html : e; var o = i.disabled, n = $("<a >"); n.addClass("dropdown-item").css({ overflow: "hidden", "text-overflow": "ellipsis" }).html(s).data("item", t), o && n.addClass("disabled"), l.push(n) }), this._dd.append(l), this.show()) : "" === this.noResultsText ? this.hide() : ((t = $("<a >")).addClass("dropdown-item disabled").html(this.noResultsText), l.push(t), this._dd.append(l), this.show()) }, c.prototype.itemSelectedLaunchEvent = function (t) { this._$el.trigger("autocomplete.select", t) }, c), d = (u.prototype.manageInlineDataAttributes = function () { var t = this.getSettings(); this._$el.data("url") && (t.resolverSettings.url = this._$el.data("url")), this._$el.data("default-value") && (this._defaultValue = this._$el.data("default-value")), this._$el.data("default-text") && (this._defaultText = this._$el.data("default-text")), void 0 !== this._$el.data("noresults-text") && (t.noResultsText = this._$el.data("noresults-text")) }, u.prototype.getSettings = function () { return this._settings }, u.prototype.getBootstrapVersion = function () { var t = "auto" === this._settings.bootstrapVersion ? $.fn.button.Constructor.VERSION.split(".").map(parseInt) : "4" === this._settings.bootstrapVersion ? [4] : "3" === this._settings.bootstrapVersion ? [3] : (console.error("INVALID value for 'bootstrapVersion' settings property: " + this._settings.bootstrapVersion + " defaulting to 4"), [4]); return t }, u.prototype.convertSelectToText = function () { var t = $("<input>"); t.attr("type", "hidden"), t.attr("name", this._$el.attr("name")), this._defaultValue && t.val(this._defaultValue), (this._selectHiddenField = t).insertAfter(this._$el); var e = $("<input>"); e.attr("type", "search"), e.attr("name", this._$el.attr("name") + "_text"), e.attr("id", this._$el.attr("id")), e.attr("disabled", this._$el.attr("disabled")), e.attr("placeholder", this._$el.attr("placeholder")), e.attr("autocomplete", "off"), e.addClass(this._$el.attr("class")), this._defaultText && e.val(this._defaultText); var s = this._$el.attr("required"); s && e.attr("required", s), e.data(u.NAME, this), this._$el.replaceWith(e), this._$el = e, this._el = e.get(0) }, u.prototype.init = function () { this.bindDefaultEventListeners(), "ajax" === this._settings.resolver && (this.resolver = new l(this._settings.resolverSettings)), 4 === this.getBootstrapVersion()[0] ? this._dd = new h(this._$el, this._settings.formatResult, this._settings.autoSelect, this._settings.noResultsText) : this._dd = new a(this._$el, this._settings.formatResult, this._settings.autoSelect, this._settings.noResultsText) }, u.prototype.bindDefaultEventListeners = function () { var s = this; this._$el.on("keydown", function (t) { switch (t.which) { case 9: s._dd.isItemFocused ? s._dd.selectFocusItem() : s._selectedItem || "" !== s._$el.val() && s._$el.trigger("autocomplete.freevalue", s._$el.val()), s._dd.hide(); break; case 13: s._dd.isItemFocused ? s._dd.selectFocusItem() : s._selectedItem || "" !== s._$el.val() && s._$el.trigger("autocomplete.freevalue", s._$el.val()), s._dd.hide(), s._settings.preventEnter && t.preventDefault(); break; case 40: s._dd.focusNextItem(); break; case 38: s._dd.focusPreviousItem() } }), this._$el.on("keyup", function (t) { switch (t.which) { case 16: case 17: case 18: case 39: case 37: case 36: case 35: break; case 13: case 27: s._dd.hide(); break; case 40: case 38: break; default: s._selectedItem = null; var e = s._$el.val(); s.handlerTyped(e) } }), this._$el.on("blur", function (t) { !s._dd.isMouseOver && s._dd.isDdMouseOver && s._dd.isShown() ? (setTimeout(function () { s._$el.focus() }), s._$el.focus()) : s._dd.isMouseOver || (s._isSelectElement ? s._dd.isItemFocused ? s._dd.selectFocusItem() : (null !== s._selectedItem && "" !== s._$el.val() || ("" !== s._$el.val() && null !== s._defaultValue ? (s._$el.val(s._defaultText), s._selectHiddenField.val(s._defaultValue)) : (s._$el.val(""), s._selectHiddenField.val("")), s._selectedItem = null), s._$el.trigger("autocomplete.select", s._selectedItem)) : null === s._selectedItem && s._$el.trigger("autocomplete.freevalue", s._$el.val()), s._dd.hide()) }), this._$el.on("autocomplete.select", function (t, e) { s._selectedItem = e, s.itemSelectedDefaultHandler(e) }), this._$el.on("paste", function (t) { setTimeout(function () { s._$el.trigger("keyup", t) }, 0) }) }, u.prototype.handlerTyped = function (t) { null !== this._settings.events.typed && !(t = this._settings.events.typed(t, this._$el)) || (t.length >= this._settings.minLength ? (this._searchText = t, this.handlerPreSearch()) : this._dd.hide()) }, u.prototype.handlerPreSearch = function () { if (null !== this._settings.events.searchPre) { var t = this._settings.events.searchPre(this._searchText, this._$el); if (!t) return; this._searchText = t } this.handlerDoSearch() }, u.prototype.handlerDoSearch = function () { var e = this; null !== this._settings.events.search ? this._settings.events.search(this._searchText, function (t) { e.postSearchCallback(t) }, this._$el) : this.resolver && this.resolver.search(this._searchText, function (t) { e.postSearchCallback(t) }) }, u.prototype.postSearchCallback = function (t) { this._settings.events.searchPost && "boolean" == typeof (t = this._settings.events.searchPost(t, this._$el)) && !t || this.handlerStartShow(t) }, u.prototype.handlerStartShow = function (t) { this._dd.updateItems(t, this._searchText) }, u.prototype.itemSelectedDefaultHandler = function (t) { var e; null != t ? ("string" == typeof (e = this._settings.formatResult(t)) && (e = { text: e }), this._$el.val(e.text), this._isSelectElement && this._selectHiddenField.val(e.value)) : (this._$el.val(""), this._isSelectElement && this._selectHiddenField.val("")), this._selectedItem = t, this._dd.hide() }, u.prototype.defaultFormatResult = function (t) { return "string" == typeof t ? { text: t } : t.text ? t : { text: t.toString() } }, u.prototype.manageAPI = function (t, e) { "set" === t ? this.itemSelectedDefaultHandler(e) : "clear" === t ? this.itemSelectedDefaultHandler(null) : "show" === t ? this._$el.trigger("keyup") : "updateResolver" === t && (this.resolver = new l(e)) }, u.NAME = "autoComplete", u); function u(t, e) { this._selectedItem = null, this._defaultValue = null, this._defaultText = null, this._isSelectElement = !1, this._settings = { resolver: "ajax", resolverSettings: {}, minLength: 3, valueKey: "value", formatResult: this.defaultFormatResult, autoSelect: !0, noResultsText: "No results", bootstrapVersion: "auto", preventEnter: !1, events: { typed: null, searchPre: null, search: null, searchPost: null, select: null, focus: null } }, this._el = t, this._$el = $(this._el), this._$el.is("select") && (this._isSelectElement = !0), this.manageInlineDataAttributes(), "object" == typeof e && (this._settings = $.extend(!0, {}, this.getSettings(), e)), this._isSelectElement && this.convertSelectToText(), this.init() } function c(t, e, s, i) { this.initialized = !1, this.shown = !1, this.items = [], this.ddMouseover = !1, this._$el = t, this.formatItem = e, this.autoSelect = s, this.noResultsText = i } function f(t, e, s, i) { this.initialized = !1, this.shown = !1, this.items = [], this.ddMouseover = !1, this._$el = t, this.formatItem = e, this.autoSelect = s, this.noResultsText = i } function p(t) { return o.call(this, t) || this } function _(t) { this._settings = $.extend(!0, {}, this.getDefaults(), t) } n = jQuery, window, document, n.fn[d.NAME] = function (e, s) { return this.each(function () { var t; (t = n(this).data(d.NAME)) || (t = new d(this, e), n(this).data(d.NAME, t)), t.manageAPI(e, s) }) } }]);