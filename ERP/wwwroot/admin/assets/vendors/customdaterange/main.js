(function () {
    var t;
    t = function () {
        function t() {
            var t, e;
            this.dateRange = ko.observable([moment().subtract(29, "days"), moment()]), this.dateRange2 = ko.observable([moment().subtract(29, "days"), moment()]), this.dateRange3 = ko.observable([moment().subtract(29, "days"), moment()]), this.dateRange4 = ko.observable([moment().subtract(29, "days"), moment()]), this.dateRange5 = ko.observable([moment().subtract(29, "days"), moment()]), $("body").is(".docs") && (t = [], this.tree = [], this.activeItem = ko.observable(), e = this, this.originalTop = $("aside").position().top, $(".content h2, .content h3").each(function () {
                var n, o;
                return o = $(this).prop("tagName"), n = {
                    name: $(this).text(),
                    id: "#" + $(this).attr("id")
                }, $(this).data("anchor", n), "H2" === o ? (t = [n], e.tree.push(t)) : (n.parent = t[0], t.push(n))
            }), this.updateActiveItem(), $(window).scroll(function (t) {
                return function () {
                    return t.updateActiveItem()
                }
            }(this))), $("body").is(".examples") && $("pre").each(function () {
                var t, e, n, o;
                return t = $(this).text(), n = $(this).children("code").is(".lang-html") ? "div" : "script", o = "<div class='example-wrapper'></div>", e = "<div><" + n + ">" + t + "</" + n + "></div>", $(this).wrap(o).parent().prepend(e)
            })
        }
        return t.prototype.updateActiveItem = function () {
            var t, e, n, o;
            return t = null, n = $(document.body).scrollTop(), e = $(".content h2, .content h3").last().offset().top, o = $(window).height(), $(".content h2, .content h3").each(function (e) {
                var o;
                if (o = $(this).offset().top - 5, 0 === e || o < n) return t = $(this).data("anchor")
            }), this.activeItem(t), $("aside").css({
                top: Math.max(this.originalTop - n, 0)
            })
        }, t
    }(), $(function () {
        return ko.applyBindings(new t)
    }),
        function () {
            var t, e, n, o;
            return n = function (t, e, n, o, a, i, r) {
                return t.beginPath(), t.moveTo(e + i, n), t.lineTo(e + o - i, n), t.quadraticCurveTo(e + o, n, e + o, n + i), t.lineTo(e + o, n + a - i), t.quadraticCurveTo(e + o, n + a, e + o - i, n + a), t.lineTo(e + i, n + a), t.quadraticCurveTo(e, n + a, e, n + a - i), t.lineTo(e, n + i), t.quadraticCurveTo(e, n, e + i, n), t.closePath(), t.fillStyle = r, t.fill()
            }, e = function (t, e, o, a, i, r, s, c, u) {
                return n(t, e, o, a, i, r, u), n(t, e + s, o + s, a - 2 * s, i - 2 * s, r - s, c)
            }, o = function (t, e, n, o, a) {
                return t.textAlign = "center", t.font = "bold 9px sans-serif", t.fillStyle = a, t.fillText(e, n, o, 16)
            }, t = function (t) {
                var e;
                return e = document.createElement("link"), e.type = "image/x-icon", e.rel = "shortcut icon", e.href = t.toDataURL("image/x-icon"), document.getElementsByTagName("head")[0].appendChild(e)
            }, $(function () {
                var a, i;
                return a = document.createElement("canvas"), a.width = 16, a.height = 16, i = a.getContext("2d"), e(i, 0, 2, 16, 14, 2, 1, "#20aa9c", "#1b8e82"), n(i, 2, 1, 3, 3, 1.5, "#1b8e82"), n(i, 11, 1, 3, 3, 1.5, "#1b8e82"), o(i, moment().format("L"), 8, 12.5, "#146960"), o(i, moment().format("L"), 8, 11.5, "#fff"), t(a)
            })
        }()
}).call(this);