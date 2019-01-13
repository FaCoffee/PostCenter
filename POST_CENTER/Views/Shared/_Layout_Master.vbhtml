<!DOCTYPE html>
<html class="no-js">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - สำนักงานองค์การอาหารและยา</title>
    <!-- JavaScript -->
    <script src="//cdn.jsdelivr.net/npm/alertifyjs@1.11.1/build/alertify.min.js"></script>
    @Scripts.Render("~/bundles/jquery")


    <!-- CSS -->
    <link rel="stylesheet" href="//cdn.jsdelivr.net/npm/alertifyjs@1.11.1/build/css/alertify.min.css" />
    <!-- Default theme -->
    <link rel="stylesheet" href="//cdn.jsdelivr.net/npm/alertifyjs@1.11.1/build/css/themes/default.min.css" />
    <!-- Semantic UI theme -->
    <link rel="stylesheet" href="//cdn.jsdelivr.net/npm/alertifyjs@1.11.1/build/css/themes/semantic.min.css" />
    <!-- Bootstrap theme -->
    <link rel="stylesheet" href="//cdn.jsdelivr.net/npm/alertifyjs@1.11.1/build/css/themes/bootstrap.min.css" />

    <!--
        RTL version
    -->
    <link rel="stylesheet" href="//cdn.jsdelivr.net/npm/alertifyjs@1.11.1/build/css/alertify.rtl.min.css" />
    <!-- Default theme -->
    <link rel="stylesheet" href="//cdn.jsdelivr.net/npm/alertifyjs@1.11.1/build/css/themes/default.rtl.min.css" />
    <!-- Semantic UI theme -->
    <link rel="stylesheet" href="//cdn.jsdelivr.net/npm/alertifyjs@1.11.1/build/css/themes/semantic.rtl.min.css" />
    <!-- Bootstrap theme -->
    <link rel="stylesheet" href="//cdn.jsdelivr.net/npm/alertifyjs@1.11.1/build/css/themes/bootstrap.rtl.min.css" />

    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.0.13/css/all.css" integrity="sha384-DNOHZ68U8hZfKXOrtjWvjxusGo9WQnrNx2sqG0tfsghAvtVlRW3tvkXWZh58N9jp" crossorigin="anonymous">

    @Styles.Render("~/css/index.css")
    @Styles.Render("~/css/drug.css")
    @Styles.Render("~/css/popup.css")
    @Styles.Render("~/css/registry.css")
    @Styles.Render("~/css/reset.css")
    @Styles.Render("~/css/style.css")
    @Styles.Render("~/css/demo.css")
    @Styles.Render("~/css/responsive-header-md.css")
    @Styles.Render("~/Content/bootstrap.css")
    @Styles.Render("~/Content/bootstrap.min.css")
    <link href="~/js/bower_components/angular-material/angular-material.css" rel="stylesheet" />
    @*<script src="~/js/bower_components/angular/angular.js"></script>
        <script src="~/js/bower_components/angular-animate/angular-animate.js"></script>
        <script src="~/js/bower_components/angular-aria/angular-aria.js"></script>
        <script src="~/js/bower_components/angular-messages/angular-messages.js"></script>
        <script src="~/AngularJs/Content/ng-file-upload.min.js"></script>
        <script src="~/js/bower_components/angular-material/angular-material.js"></script>*@
    <!-- Angular Material requires Angular.js Libraries -->
    <script src="https://ajax.googleapis.com/ajax/libs/angularjs/1.6.9/angular.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/angularjs/1.6.9/angular-animate.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/angularjs/1.6.9/angular-aria.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/angularjs/1.6.9/angular-messages.min.js"></script>
    <script src="~/js/content/date.format.js"></script>
    <link href="~/dist/css/bootstrap-datepicker.css" rel="stylesheet" />
    <script src="~/dist/js/bootstrap-datepicker-custom.js"></script>
    <script src="~/dist/locales/bootstrap-datepicker.th.min.js" charset="UTF-8"></script>
    <!-- Angular Material Library -->
    <script src="https://ajax.googleapis.com/ajax/libs/angular_material/1.1.8/angular-material.min.js"></script>

    <script src="~/AngularJs/COMPLAIN_CTRL.js"></script>
    <script src="~/AngularJs/CENTER_SV.js"></script>
    @*<script src="~/AngularJs/RECALL_CTRL.js"></script>*@

    <style>
        #content #middle-content .contain-page-topic .body-conf {
            opacity: 0;
            visibility: hidden;
        }
    </style>
    <script>
        function includeHTML(cb) {
            var z, i, elmnt, file, xhttp;
            /*loop through a collection of all HTML elements:*/
            z = document.getElementsByTagName("*");
            for (i = 0; i < z.length; i++) {
                elmnt = z[i];
                /*search for elements with a certain atrribute:*/
                file = elmnt.getAttribute("kk-include");
                if (file) {
                    /*make an HTTP request using the attribute value as the file name:*/
                    xhttp = new XMLHttpRequest();
                    xhttp.onreadystatechange = function () {
                        if (this.readyState == 4) {
                            if (this.status == 200) { elmnt.innerHTML = this.responseText; }
                            if (this.status == 404) { elmnt.innerHTML = "Page not found."; }
                            /*remove the attribute, and call this function once more:*/
                            elmnt.removeAttribute("kk-include");
                            includeHTML(cb);
                        }
                    }
                    xhttp.open("GET", file, true);
                    xhttp.send();
                    /*exit the function:*/
                    return;
                }
            }
            cb();
        };
        function loadScript(url, callback) {
            // Adding the script tag to the head as suggested before
            var head = document.getElementsByTagName('head')[0];
            var script = document.createElement('script');
            script.type = 'text/javascript';
            script.src = url;

            // Then bind the event to the callback function.
            // There are several events for cross browser compatibility.
            script.onreadystatechange = callback;
            script.onload = callback;

            // Fire the loading
            head.appendChild(script);
        }
    </script>

    @Scripts.Render("~/bundles/modernizr")

</head>
<body class="font-face">
    @Html.Partial("header", Nothing)
    <section id="page">
        <div class="content-overlay"></div>
        <div>@Html.Partial("popup", Nothing)</div>
        <div>@Html.Partial("menu_left", Nothing)</div>
        <div id="content" ng-app="COMPLAIN_APP" ng-controller="COMPLAIN_CTRL">
            <div id="middle-content">
                <div class="body-container">
                    <div class="side-bar">
                        <ul>
                            <li ng-repeat="datas in GET_PROCESS_MENU_LIST">
                                <a ng-href="{{datas.URL_MENU}}">
                                    <img ng-src="{{datas.URL_ICON}}">
                                    <span>{{datas.MENU_NAME}}</span>
                                </a>
                            </li>
                        </ul>
                        <div class="responsive-MENU"></div>
                    </div>
                    @RenderBody()
                </div>
            </div>
        </div>
    </section>
    @*<script type="text/javascript" src="js/content/jquery-3.1.1.min.js"></script>*@

    @*<script type="text/javascript" src="js/fontawesome-all.min.js"></script>*@
    <script>
        $(document).ready(function () {
            $('.datepicker').datepicker({
                format: 'dd/mm/yyyy',
                todayBtn: true,
                language: 'th',             //เปลี่ยน label ต่างของ ปฏิทิน ให้เป็น ภาษาไทย   (ต้องใช้ไฟล์ bootstrap-datepicker.th.min.js นี้ด้วย)
                thaiyear: true              //Set เป็นปี พ.ศ.
            }).datepicker("setDate", "0");  //กำหนดเป็นวันปัจุบัน
        });


        var cb = function () {
            loadScript("/js/content/home.js");
            loadScript("/js/content/drug.js");
            loadScript("/js/content/registry.js");
        };
        includeHTML(cb);

     function send_plan() {
        var url = '@Url.Action("ENTRY_CREATE_PLAN", "Qsm")';
        location.href = url + '?PLAN_TITLE=' + document.getElementById("txt_name").value;
     }
    </script>
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>

