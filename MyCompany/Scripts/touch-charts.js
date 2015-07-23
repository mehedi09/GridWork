/*!
* Data Aquarium Framework - Charts for Touch UI
* Copyright 2008-2015 Code On Time LLC; Licensed MIT; http://codeontime.com/license
*/
(function(){function e(n){return n.match(/pie|donut/i)}function n(n,t,i,r){i||(i="visualization");r||(r="1");var f=i+r+(typeof n=="string"?n:n.join("-")),u=s[f];u&&u.loaded?t():u&&!u.loaded?u.callbacks.push(t):(u=s[f]={loaded:!1,callbacks:[t]},google.load(i,r,{packages:n,callback:function(){u.loaded=!0;$(u.callbacks).each(function(){this()})}}))}function c(t,i){var u=$('<div class="app-chart-headerbar"><\/div>').appendTo(i),e=$('<div class="app-chart-mini"><\/div>').appendTo(u).attr("title",r.ShowChart),s=t.Properties.title||t.Title,a=$('<span class="app-chart-header"><\/span>').appendTo(u),f=$('<div class="app-chart-data app-scrollable"><\/div>').appendTo(i),h=$("<table><\/table>").appendTo(f),c=!t.ChartType.match(/map|table/);c||e.hide();i.closest(".app-chart").addClass("app-chart-has-data");t.ShowData=!0;n("corechart",function(){var r=google.visualization.arrayToDataTable(t.ChartData),p=r.getNumberOfRows(),y=r.getNumberOfColumns(),v=$("<tr><\/tr>").appendTo(h),u,i,n,f;for(a.text(s.substring(0,1).toUpperCase()+s.substring(1)),l(t,r),i=0;i<y;i++)n=r.getColumnLabel(i),f=$("<th><\/th>").appendTo(v),n!=null&&f.text(n).attr("title",n);for(u=0;u<p;u++)for(v=$("<tr><\/tr>").appendTo(h),i=0;i<y;i++)n=r.getFormattedValue(u,i),f=$("<td><\/td>").appendTo(v),n!=null&&f.text(n=="0"?"":n).attr("title",n);c&&o(t,e)});f.height(Math.floor(i.height()-u.outerHeight(!0)));f.width(i.width())}function o(n,t){var i=a[n.ChartType];i&&i(n,t)}function t(n,t,i){var u=e(n.ChartType),o=n.Properties.title||n.Title,f,r;i||(i={});i.legend||(i.legend={});i.hAxis||(i.hAxis={});i.vAxis||(i.vAxis={});i.chartArea||(i.chartArea={});i.tooltip||(i.tooltip={});i.title=o.charAt(0).toUpperCase()+o.slice(1);i.width=Math.floor(t.width())-1;i.height=Math.floor(t.height())-1;i.tooltip.trigger="focus";n.ChartData[0].length<=2&&(u||(i.legend.position="none"),u&&(n.Properties.maximize=!0));u&&(i.sliceVisibilityThreshold=0);for(f in n.Properties)if(n.Properties.hasOwnProperty(f)){r=n.Properties[f];switch(f){case"crosshair":i.crosshair={orientation:r==0?"both":r,trigger:"both"};break;case"maximize":u?(i.chartArea.top="15%",i.chartArea.width="80%",i.chartArea.height="80%"):(i.titlePosition="in",i.chartArea.width="100%",i.chartArea.height="100%",i.legend.position||(i.legend.position="in"));i.axisTitlesPosition="in";i.hAxis.textPosition="in";i.vAxis.textPosition="in";break;case"haxistitle":i.hAxis.title=r;break;case"vaxistitle":i.vAxis.title=r;break;case"region":i.region=r;break;case"displaymode":i.displayMode=r;break;case"resolution":i.resolution=r;break;case"curve":i.curveType="function";break;case"explorer":i.explorer={};break;case"maptype":i.mapType=r;break;case"enablescrollwheel":i.enableScrollWheel=!0;break;case"usemaptypecontrol":i.useMapTypeControl=!0;break;case"pointshape":i.pointShape=r;break;case"pointsize":i.pointSize=r;break;case"orientation":i.orientation=r;break;case"animation":i.animation={startup:!0,duration:500,easing:"out"}}}return n.ShowData&&(i.legend.position="none",i.axisTitlesPosition="none",i.height="100%",i.titlePosition="none",i.chartArea.top="0",i.chartArea.width="100%",i.chartArea.height="100%",i.enableInteractivity=!1),$("body").hasClass("app-theme-dark")&&(i.backgroundColor="#1f1f1f",i.hAxis.textStyle={color:"white"},i.hAxis.gridlines={color:"#000"},i.vAxis.textStyle={color:"white"},i.vAxis.gridlines={color:"#000"},i.legend.textStyle={color:"#999"},i.legend.scrollArrows={activeColor:"#fff",inactiveColor:"#777"},i.legend.pagingTextStyle={color:"#999"},i.titleTextStyle={color:"white"},u&&(i.pieSliceBorderColor="#111")),i}function l(n,t){var o=n.ValueFieldNames.length,c=n.ValueFieldNames.length,r;for(name in n.Formats){var i=n.Formats[name],u=/(\w+)(\d)/.exec(name),s=u[1],h=u[2],f=n.ValueFieldNames.indexOf(s,h),e;if(f!=-1&&i){switch(i.toLowerCase()){case"c":case"C":i="¤00.00";break;case"d":case"D":i="00.00";break;case"e":case"E":i="0.######E+000";break;case"f":case"F":i="00.00";break;case"n":case"N":i="00.00";break;case"p":case"P":i="%";break;case"x":case"X":i="00.00"}for(e=new google.visualization.NumberFormat({pattern:i}),r=f+1;r<n.Data[0].length;r=r+o)e.format(t,r)}}}function i(n,t,i,r){function o(){}var f=google.visualization.arrayToDataTable(n.ChartData),e=n.ChartType.match(/geo/i);l(n,f);u.desktop()||e||o();n.Properties.animation&&!e&&n.ChartType!="map"&&i.draw(null,r);i.draw(f,r);u.desktop()&&!e&&(google.visualization.events.addListener(i,"select",function(){if(r.tooltip.trigger=="focus"){r.tooltip.trigger="selection";var n=i.getSelection();return o(),i.draw(f,r),i.setSelection(n),!1}}),google.visualization.events.addListener(i,"click",function(n){n.targetID.match(/^action/)||r.tooltip.trigger!="selection"||(r.tooltip.trigger="focus",i.removeAction("filter"),i.removeAction("exclude"),i.setSelection(null),i.draw(f,r))}))}var v=$(window),y=$.mobile,u=$app.touch,s={},r=Web.DataViewResources.Presenters.Charts,f=Web.DataViewResources.Mobile,h,a;$(document).on("resizing.app searching.app",function(){$.mobile.activePage.find(".app-chart-inner").children().hide()});$(document).on("vclick",".app-chart",function(n){function w(){delete e.ShowData;i.viewProp("chartsConfig",l);var r=t.closest(".app-chart-list").parent().data("pivots")["pivot"+p],n=t.closest(".app-chart").find(".app-chart-inner");n.empty();n.closest(".app-chart").removeClass("app-chart-has-data");r.ShowData=!1;o(r,n)}var t=$(n.target),b=t.closest(".app-echo"),i=b.length?$app.find(b.attr("data-for")):u.dataView(),h=t.closest(".app-chart").data("data-context");if(i&&h){var p=h.Id,l=i.viewProp("chartsConfig"),e=l&&l[p],v=!$("body").hasClass("app-sidebar-undocked"),y=$(window).width()/parseFloat($("body").css("font-size")),k=v&&y>=50||!v&&y>=40,d=v&&y>=85||!v&&y>=62,a=e.size?e.size:"small",s=[];return t.is(".app-btn-more")&&!$app.mobile.busy()?$app.mobile.callWithFeedback(t.closest(".ui-btn"),function(){a!="large"||d||(a="medium");a!="medium"||k||(a="small");var n=t.closest(".app-chart-list").parent().data("pivots")["pivot"+p];n.ChartType.match(/map|table/)||(e.ShowData?s.push({text:r.ShowChart,icon:"chart",callback:w}):s.push({text:r.ShowData,icon:"grid",callback:function(){e.ShowData=!0;i.viewProp("chartsConfig",l);var r=t.closest(".app-chart").find(".app-chart-inner");r.empty();c(n,r)}}));t.closest(".app-chart-list").find(".app-chart").length>1?(s.push({text:r.Sizes.Label}),s.push({text:r.Sizes.Small,icon:a=="small"?"check":"",callback:function(){delete e.size;e.resized=!0;i.viewProp("chartsConfig",l);$app.touch.presenter("show",{name:"Charts",id:i._id,container:t.closest(".app-wrapper")})}}),k&&s.push({text:r.Sizes.Medium,icon:a=="medium"?"check":"",callback:function(){e.size="medium";e.resized=!0;i.viewProp("chartsConfig",l);$app.touch.presenter("show",{name:"Charts",id:i._id,container:t.closest(".app-wrapper")})}}),d&&s.push({text:r.Sizes.Large,icon:a=="large"?"check":"",callback:function(){e.size="large";e.resized=!0;i.viewProp("chartsConfig",l);$app.touch.presenter("show",{name:"Charts",id:i._id,container:t.closest(".app-wrapper")})}})):s.push({text:r.Sizes.Auto,icon:"check",callback:function(){}});s.push({text:f.Filter});h.ColumnFieldNames&&h.ColumnFieldNames.length&&s.push({text:i.findField(h.ColumnFieldNames[0]).HeaderText,icon:"filter",callback:function(){u.configureFilter({field:h.ColumnFieldNames[0],scope:i._id,mode:"field"})}});h.RowFieldNames&&h.RowFieldNames.length&&s.push({text:i.findField(h.RowFieldNames[0]).HeaderText,icon:"filter",callback:function(){u.configureFilter({field:h.RowFieldNames[0],scope:i._id,mode:"field"})}});u.listPopup({anchor:t.closest("a"),iconPos:"right",items:s})}):t.closest(".app-chart-mini").length&&w(),!1}});$(document).on("taphold",".app-chart",function(n){var t=$(n.target);t.is("td")&&t.closest(".app-chart-data").length&&u.listPopup({anchor:t,title:t.text()})});a={area:function(r,u){n("corechart",function(){var n=t(r,u),f=new google.visualization.AreaChart($(u).get(0));i(r,u,f,n)})},areastacked:function(r,u){n("corechart",function(){var n=t(r,u,{isStacked:!0}),f=new google.visualization.AreaChart($(u).get(0));i(r,u,f,n)})},bar:function(r,u){n("corechart",function(){var n=t(r,u),f=new google.visualization.BarChart($(u).get(0));i(r,u,f,n)})},barstacked:function(r,u){n("corechart",function(){var n=t(r,u,{isStacked:!0}),f=new google.visualization.BarChart($(u).get(0));i(r,u,f,n)})},column:function(r,u){n("corechart",function(){var n=t(r,u),f=new google.visualization.ColumnChart($(u).get(0));i(r,u,f,n)})},columnstacked:function(r,u){n("corechart",function(){var n=t(r,u,{isStacked:!0}),f=new google.visualization.ColumnChart($(u).get(0));i(r,u,f,n)})},candlestick:function(r,u){n("corechart",function(){var n=t(r,u),f=new google.visualization.CandlestickChart($(u).get(0));i(r,u,f,n)})},donut:function(r,u){n("corechart",function(){var n=t(r,u,{pieHole:.4,backgroundColor:"transparent"}),f=new google.visualization.PieChart($(u).get(0));i(r,u,f,n)})},geo:function(r,u){n("geochart",function(){var n=t(r,u,{backgroundColor:"transparent"}),f=new google.visualization.GeoChart($(u).get(0));i(r,u,f,n)})},map:function(r,u){n("map",function(){var n=t(r,u,{showTip:!0}),f=new google.visualization.Map($(u).get(0));i(r,u,f,n)})},line:function(r,u){n("corechart",function(){var n=t(r,u,{showTip:!0}),f=new google.visualization.LineChart($(u).get(0));i(r,u,f,n)})},pie:function(r,u){n("corechart",function(){var n=t(r,u,{title:r.Title,backgroundColor:"transparent"}),f=new google.visualization.PieChart($(u).get(0));i(r,u,f,n)})},pie3d:function(r,u){n("corechart",function(){var n=t(r,u,{backgroundColor:"transparent",is3D:!0}),f=new google.visualization.PieChart($(u).get(0));i(r,u,f,n)})},scatter:function(r,u){n("corechart",function(){var n=t(r,u),f=new google.visualization.ScatterChart($(u).get(0));i(r,u,f,n)})},table:function(r,u){n("table",function(){var n=t(r,u),f=new google.visualization.Table($(u).get(0));i(r,u,f,n)})}};$app.touch.presenter("register",{name:"Charts",icon:function(){return"chart"},text:function(){return r.Text},supports:function(n){var u=!1;if($(n._fields).each(function(){if(this.Tag&&this.Tag.indexOf("pivot")!=-1)return u=!0,!1}),u)n.AutoPivots=null;else{if(n.AutoPivots&&$.isEmptyObject(n.AutoPivots))return!0;var t=1,d=n._fields[0].Label,i=[],o=0,a=0,h=["pie3d","column","donut","bar"],r=[],f=0,v=0,c=["line","column","area"],y=0,l=["columnstacked-top5","area-top7","column-top5","barstacked-top5"],p=[],w=!1;n.AutoPivots={};function s(){return h[a++%h.length]}function b(){return c[v++%c.length]}function k(){return l[y++%l.length]}$(n._fields).each(function(){var t=this;n.AutoPivots[t.Name]=[];t.ItemsDataController&&i.push(t.Name);t.Type=="DateTime"&&r.push(t.Name);t.DataFormatString=="c"&&p.push(t.Name)});$(i).each(function(){if(t>9||!r[f])return!1;var u=this,e=r[f];n.AutoPivots[i[o++%i.length]].push("pivot"+t+"-col1-sortdescbyvalue-"+k());n.AutoPivots[r[f++%r.length]].push("pivot"+t+++"-row1-date-all-hideblank")});o=0;f=0;$(n._fields).each(function(){var u,r,f,h;if(t>9)return!1;if(u=this,r=u.Name,u.IsPrimaryKey)return!0;if(u.ItemsDataController)n.AutoPivots[r].push("pivot"+t+++"-row1-top10-other-sortdescbyvalue-"+s());else switch(u.Type){case"Int16":case"Int32":case"Int64":case"Single":case"Double":case"Decimal":if(i.length!=0){if(f="sum",h=s(),r.match(/salary/i))f="avg";else if(r.match(/total/i))f="sum";else if(u.DataFormatString=="{0:c}"||r.match(/price|discount/i))for(f="avg";e(h);)h=s();e(h)&&(f="sum");n.AutoPivots[r].push("pivot"+t+"-val1-"+f+"-"+h);n.AutoPivots[i[o++%i.length]].push("pivot"+t+++"-row1-top7-other-sortdescbyvalue")}break;case"DateTime":r.match(/birth|hire/i)?n.AutoPivots[r].push("pivot"+t+++"-row1-month-all-pie3d"):n.AutoPivots[r].push("pivot"+t+++"-row1-"+b()+"-date-all-hideblank");break;case"String":w||r.match(/country/i)&&n.AutoPivots[r].push("pivot"+t+++"-row1-geo")}});t>1&&(u=!0)}return u},show:function(n){function l(n){var u,e,o,s,h;a();u=$('<ul class="app-listview app-grid"/>').appendTo(t);n?(s=$('<li data-icon="filter" class="ui-last-child"><a href="#app-filter" class="ui-btn ui-icon-filter ui-btn-icon-left"><p/><\/a><\/li>').appendTo(u).find("a"),h=String.format(r.DataWarning,__settings.maxPivotRowCount),s.attr("title",f.Filter).find("p").text(h)):(e=$('<li data-icon="refresh"><a href="#app-refresh" class="ui-btn ui-icon-refresh ui-btn-icon-left"><p/><\/a><\/li>').appendTo(u).find("a"),e.attr("title",Web.DataViewResources.Pager.Refresh).find("p").text(Web.DataViewResources.Data.NoRecords),i._filter&&i._filter.length&&!i.filterIsExternal()&&(o=$('<li data-icon="filter" class="ui-last-child"><a href="#app-clear-filter" class="ui-btn ui-icon-filter ui-btn-icon-left"><p/><\/a><\/li>').appendTo(u).find("a"),o.attr("title",f.ClearFilter).find("p").text(f.ClearFilter)));u.listview()}function a(){t.find(".app-chart").each(function(){$(this).removeData()});t.empty()}function y(n){for(pivot in n)$(n[pivot].Data).each(function(){for(var t=this,n=0;n<t.length;)t[n]=v(t[n]),n++}),n[pivot].Title=v(n[pivot].Title),n[pivot].ChartData=JSON.parse(JSON.stringify(n[pivot].Data)),$(n[pivot].ChartData).each(function(){for(var i=this,t=this,n=0,n=0;n<t.length;n++)t[n]==null&&(t[n]=0)})}function v(n){if(!n||!isNaN(n)||isFinite(n))return n;var t=n.match(/\$(\S+)/g);return $(t).each(function(){var f=this.replace(/\d*/g,""),t=f.replace(/[$\d]*/g,""),u=r.ChartLabels[t];u?(t.match(/Quarter|Week/)&&(u=u.substring(0,1)),n=n.replace(f,u)):t=="CurrentViewLabel"&&(n=n.replace(f,i._view.Label));t=="Other"&&(n.isOther=!0)}),n}function s(){var y,h,s,n,w,nt=[],ft=0,k=t.closest(".app-wrapper"),tt,v=0,g=1,b,et=t.find(".app-chart"),it,rt,d=!1,ht,p,f;et.length>0&&(ht=k.scrollTop(),$(et).each(function(){var n=$(this);if(n.position().top>0)return e[n.data("data-context").Id].lastScrollPosition=!0,!1}));a();$('<div class="app-chart"><span class="app-chart-inner"/><\/div><div class="app-chart"><span class="app-chart-inner"/><\/div><div class="app-chart"><span class="app-chart-inner"/><\/div>').appendTo(t);b=t.find(".app-chart");$(b[0]).offset().left<$(b[1]).offset().left&&g++;$(b[1]).offset().left<$(b[2]).offset().left&&g++;b.remove();t.empty();for(w in u)if(n=u[w],n.ChartType&&n.RecordCount!=0)d||(n.Properties.medium||n.Properties.large?d=!0:e&&(f=e[n.Id],f&&f.size&&f.size.match(/medium|large/)&&(d=!0))),v++;else continue;v==1&&(d=!0);for(w in u)(n=u[w],placeholder=$('<div class="app-chart"><\/div>').data("data-context",n),inner=$('<span class="app-chart-inner"><\/span>').appendTo(placeholder),moreBtn=$('<a class="ui-btn"><span class="app-btn-more">&nbsp;<\/span><\/a>').appendTo(placeholder).attr("title",r.More),n.ChartType&&n.RecordCount!=0)&&(placeholder.appendTo(t),y||(s=k.height(),tt=k.find(".app-presenter-instruction:visible"),tt.length&&(s-=tt.outerHeight()),s=Math.floor(s),y=inner.width(),h=g==3?v<=3?Math.min(s,y*1.33):Math.min(y*.66,Math.max(s/3,y*.5))-1:g==2?v<=4?Math.max(s/2,y*.5):y*.66:s*.66,d&&v<=3&&(h=s*.5),h>s&&(h=y*.66,h>s&&(h=s)),h=Math.floor(h)),p=h,f=e[n.Id],f||(f=e[n.Id]={}),f.size||(n.Properties.small!=null?delete f.size:n.Properties.medium!=null?f.size="medium":n.Properties.large!=null&&(f.size="large")),f.size&&(f.size=="medium"?(v>2&&(p=h*2+1),placeholder.addClass("app-chart-medium")):f.size=="large"&&(p=s,placeholder.addClass("app-chart-large"))),v==1&&(placeholder.addClass("app-chart-large"),p=s),f.resized?(it=placeholder,delete f.resized):f.lastScrollPosition&&(rt=placeholder,delete f.lastScrollPosition),f.ShowData||n.ChartType=="table"?n.ShowData=!0:n.ShowData&&(n.ShowData=!1),p<150&&(p=150),nt.push(inner.height(p)));if($('<div class="app-clear-fix"><\/div>').appendTo(t),setTimeout(function(){for(w in u)(n=u[w],n.ChartType&&n.RecordCount!=0)&&(n.ShowData?c(n,$(nt[ft++])):o(n,nt[ft++]))},10),v==0&&l(!1),t.closest(".app-echo").length==0&&$('<div class="app-promo-filler"><\/div>').appendTo(t),i.viewProp("chartsConfig",e),v>1&&(it||rt)){var ot=it||rt,ut=ot.outerHeight(),ct=ut<k.height()?(k.height()-ut)/2:0,st=ot.position().top-ct;st>ut/3&&t.closest(".app-wrapper").scrollTop(st)}}var p=this,i=$app.find(n.id),w=i._filter,t=n.container.find(".app-chart-list"),u=n.container.data("pivots"),e=i.viewProp("chartsConfig")||{};if(t.length==0&&(t=$('<div class="app-chart-list"><\/div>').appendTo(n.container)),(n.reset||u&&i.dataSignature()!=n.container.data("signature"))&&(u=null),i._totalRowCount>__settings.maxPivotRowCount){l(!0);return}u&&u.length!=0?s():($app.touch.busyIndicator(!0),t.find(".app-chart-inner").children().hide(),$app.execute({controller:i._controller,command:"Pivot",pivotDefinitions:i.AutoPivots,view:i._viewId,_filter:i.combinedFilter(),tags:i.get_tags(),success:function(t){u=t.Pivots;y(u);n.container.data("signature",i.dataSignature());n.container.data("pivots",u);h?s():$.getScript("https://www.google.com/jsapi",function(){h=!0;s()});$app.touch.busyIndicator(!1)},error:function(n){$app.touch.busyIndicator(!1);$app.alert(String.format("{0}\n{1}",n.get_message(),n.get_stackTrace()))}}))},hide:function(){},dispose:function(n){n.container.removeData("pivots signature");n.container.find("app-chart").each(function(){$(this).removeData()})}})})(),function(){function w(n,i,r){var e=n.closest(".app-echo").length>0,h=e?0:u,c=i.getFullYear(),l=$('<div class="app-calendar-load-at-top"><\/div>').appendTo(n),v=$('<a href="#" class="dv-load-at-top ui-btn"/>').appendTo(l).text(t.Loading),f,o,a;for(e&&l.hide(),f=c-h;f<=c+h;f++)s(f,null,r,n);o=$('<div class="app-calendar-load-at-bottom"><\/div>').appendTo(n);a=$('<a href="#" class="dv-load-at-bottom ui-btn">Load more<\/a>').appendTo(o).text(t.Loading);e&&o.hide()}function b(n,i){var e=n.closest(".app-echo").length>0,y=e?0:u,s=i.getMonth(),c=s,f=new Date(i.getFullYear(),i.getMonth()),w,p=$('<div class="app-calendar-load-at-top"><\/div>').appendTo(n),k=$('<a href="#" class="dv-load-at-top ui-btn"/>').appendTo(p).text(t.Loading),a,v,b;for(e&&p.hide(),a=s-y;a<=s+y;a++)h(f).appendTo(n),f.setMonth(c+1),c=f.getMonth(),f.getFullYear()==r&&c==l&&(o=w);v=$('<div class="app-calendar-load-at-bottom"><\/div>').appendTo(n);b=$('<a href="#" class="dv-load-at-bottom ui-btn">Load more<\/a>').appendTo(v).text(t.Loading);e&&v.hide()}function s(n,t,u,f){for(var h,s=$('<div class="app-calendar-year"><h1>'+n+"<\/h1><\/div>").data("year",n).attr("data-calendar-year",n),l,a,c,y,e=0;e<=11;e++){for(l=i.AbbreviatedMonthNames[e].toUpperCase(),a=$('<div class="app-calendar-month"><div class="app-calendar-month-header">'+l+"<\/div><\/div>").attr("data-calendar-month",e).appendTo(s),c=$("<table><\/table>").appendTo(a),y=$("<tr><\/tr>").appendTo(c),h=0;h<7;h++)$("<th><\/th>").text(i.ShortestDayNames[h].substr(0,1)).appendTo(y);v(n,e,c);n==r&&e==1&&(o=s)}return $('<div class="app-clear-fix"><\/div>').appendTo(s),!f||s.appendTo(f),s}function h(n){var t=n.getMonth(),u=i.AbbreviatedMonthNames[t].toUpperCase(),r=$('<div class="app-calendar-month"><div class="app-calendar-month-header">'+u+"<\/div><\/div>").attr("data-calendar-year",n.getFullYear()).attr("data-calendar-month",t),f=$("<table><\/table>").appendTo(r);return v(n.getFullYear(),t,f),r}function v(n,t,i){var r=new Date(n,t,1),u=r.getDay(),f=new Date(n,t+1,1),c=f.getDay(),e,o=0,s,h;for(c!=0&&f.setDate(f.getDate()+(6-c)+1),u!=0&&r.setDate(r.getDate()-u);r<f;)u=r.getDay(),u==0&&(o++,e=$("<tr><\/tr>").appendTo(i)),s=$("<td>&nbsp;<\/td>").appendTo(e),r.getMonth()==t&&(s.text(r.getDate()),y.setHours(0,0,0,0)==r.setHours(0,0,0,0)&&s.addClass("current-day")),r.setDate(r.getDate()+1);while(o<6)for(o++,e=$("<tr><\/tr>").appendTo(i),h=0;h<7;h++)$("<td>&nbsp;<\/td>").appendTo(e)}var k=$(window),d=$.mobile,c=$app.touch,e=Web.DataViewResources,t=e.HeaderFilter,g=e.Presenters.Calendar,nt=e.Mobile,i=Sys.CultureInfo.CurrentCulture.dateTimeFormat,n=new Date,y=new Date(n.getFullYear(),n.getMonth(),n.getDate()),r=n.getFullYear(),l=n.getMonth(),o,u=1,f=10,a=/calendar(\d+)-(\w+)(:['"]?(\w+)['"]?)?/g,p;$(document).on("vclick",".app-calendar",function(n){var a=$(n.target),d=a.closest(".app-echo"),p=d.length?$app.find(d.attr("data-for")):c.dataView(),t,w,b,i,r,o,k,l;if(p){if(t=p.viewProp("calendarConfig")||{},a.is(".dv-load-at-top")||a.hasClass("dv-load-at-bottom")){$app.touch.busyIndicator(!0);w=a.closest(".app-calendar > div");b=w.closest(".app-wrapper");switch(t.mode){case"year":i=w.find(".app-calendar-year");break;case"month":i=w.find(".app-calendar-month")}if(a.hasClass("dv-load-at-top")){i.length>f&&i.slice(f).remove();var v=i.first(),e,g=0,o=Number(v.data("calendar-year")),nt=v.data("calendar-month")!=null?Number(v.data("calendar-month")):1,r=new Date(o,nt);for(l=0;l<=u;l++)t.mode=="year"?(r.setFullYear(o-1),o=r.getFullYear(),e=s(o,[],t)):t.mode=="month"&&(r.setMonth(r.getMonth()-1),e=h(r)),e.insertBefore(v),v=e,g+=e.outerHeight(!0);p.viewProp("calendarConfig",t);b.scrollTop(g)}else{var y=i.last(),e,o=Number(y.data("calendar-year")),nt=y.data("calendar-month")!=null?Number(y.data("calendar-month")):1,r=new Date(o,nt);for(i.length>f&&(i.slice(0,i.length-f).remove(),k=0,i.each(function(){k+=$(this).height()}),b.scrollTop(k-1)),l=0;l<=u;l++)t.mode=="year"?(r.setFullYear(o+1),o=r.getFullYear(),e=s(o,[],t)):t.mode=="month"&&(r.setMonth(r.getMonth()+1),e=h(r)),e.insertAfter(y),y=e;p.viewProp("calendarConfig",t)}$app.touch.busyIndicator(!1)}return!1}});$app.touch.presenter("register",{name:"calendar",icon:function(){return"calendar"},text:function(){return"Calendar"},supports:function(){return!1;var n,t},show:function(t){function tt(){var t=p||o;if(t){var n=k.outerHeight(),r=n<k.height()?(k.height()-n)/2:0,i=t.position().top-r;i>n/3&&f.closest(".app-wrapper").scrollTop(i)}}var ut=this,u=$app.find(t.id),y=u.Calendars,ft=u._filter,it=t.container.closest(".app-echo").length>0,f=t.container.find(".app-calendar"),k=t.container.closest(".app-wrapper"),et=t.container.data("pivots"),v=u.viewProp("calendarConfig")||{},e=v.mode||"year",rt,s,d,g,nt,h,a;if(!$.isEmptyObject(y)){if(rt=v.activeCalendar||y[Object.keys(y)[0]],f.length>0){if(g=t.container.find(".app-calendar > div:visible"),$app.touch.bar("show",t.container.data("cal-header")),$app.touch.bar("show",t.container.data("cal-footer")),nt=String.format(".app-calendar-{0}view",e),!t.redraw&&g.is(nt))return;g.hide()}else if(f=$('<div class="app-calendar"><\/div>').appendTo(t.container),!it){s=$('<div class="app-bar-calendar"><\/div>').appendTo($app.touch.bar("create",{type:"header",page:t.container}));currentYearMonth=$('<div class="app-calendar-scope"><\/div>').appendTo(s);switch(e){case"year":currentYearMonth.text(r);break;case"month":default:currentYearMonth.html(String.format("<b>{0}<\/b> {1}",i.MonthNames[l],r))}$app.touch.tabs("create",{container:$('<div class="app-tabs"><\/div>').appendTo(s),tabs:[{text:"Day",value:"day",selected:e=="day"},{text:"Week",value:"week",selected:e=="week"},{text:"Month",value:"month",selected:e=="month"},{text:"Year",value:"year",selected:e=="year"}],change:function(n){var i=u.viewProp("calendarConfig");i.mode=n.value;u.viewProp("calendarConfig",i);t.container=t.container.parent();c.presenter("show",t)}});t.container.data("cal-header",s);$app.touch.bar("show",s);d=$('<div class="app-bar-calendar-footer">This is the footer of the calendar<br/>A lot more can be placed here.<\/div>').appendTo($app.touch.bar("create",{type:"footer",page:t.container}));$('<div style="overflow-x:auto;-ms-overflow-style:scrollbar;margin-top:-.5em;margin-left:-1em;margin-right:-1em"><div style="width:5000px;height:1px"><\/div><\/div>').insertBefore(d.contents().first());t.container.data("cal-footer",d)}$app.touch.busyIndicator(!0);switch(e){case"month":h=f.find(".app-calendar-monthview");h.length>0?h.show():(h=$('<div class="app-calendar-monthview"><\/div>').appendTo(f),b(h,n,v));tt();break;case"year":default:a=f.find(".app-calendar-yearview");a.length>0?a.show():(a=$('<div class="app-calendar-yearview"><\/div>').appendTo(f),w(a,n,v));tt()}$app.touch.busyIndicator(!1)}},hide:function(n){$app.touch.bar("hide",n.container.data("cal-header"));$app.touch.bar("hide",n.container.data("cal-footer"))},dispose:function(n){var t=n.container.data("cal-header"),i;!t||t.off();$app.touch.tabs("destroy",{container:t});$app.touch.bar("remove",t);i=n.container.data("cal-footer").off();$app.touch.bar("remove",i);n.container.removeData()}})}();