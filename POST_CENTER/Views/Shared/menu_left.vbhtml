@Imports Newtonsoft.Json
<div id="menu-left">
    <div style="opacity: 0;" class="wrap-menu-left">
        @code
            Dim _CLS As New CLS_SESSION
            Dim cookie As HttpCookie = Request.Cookies.[Get]("POST_USER_COOKIE")
            Dim token = cookie("JSON")

            Dim urldecode = Server.UrlDecode(token)
            Dim data As String = JsonConvert.DeserializeObject(urldecode)
            Dim base64de = System.Convert.ToString(token)

            Dim clsxml As New Cls_XML
            clsxml.ReadData(data)

            _CLS.CITIZEN_ID = clsxml.Get_Value_XML("Citizen_ID")
            _CLS.CITIZEN_ID_AUTHORIZE = clsxml.Get_Value_XML("CITIEZEN_ID_AUTHORIZE")
            _CLS.GROUPS = clsxml.Get_Value_XML("Groups")
            _CLS.SYSTEM_ID = clsxml.Get_Value_XML("System_ID")
            _CLS.PVCODE = clsxml.Get_Value_XML("pvcode")
            _CLS.Name = clsxml.Get_Value_XML("Name")
            Session("CLS") = _CLS
        End Code
        <div class="contain-profile">
            <div class="menu-profile"></div>
            <div class="pic-part">
                <img class="pic-profile" src="~/images/home/noname.png">
                <div class="status green"></div>
            </div><div class="name-part">
                <a class="name-profile">
                    <span class="t15">
                        @_CLS.Name
                    </span>
                    <span class="atslug">
                        @*@akeekek*@
                    </span>
                    <span class="t15 position">
                        @*เจ้าหน้าที่ดูแลระบบ<br>
                        สำนักงานอาหารและยา*@
                    </span>
                </a>
            </div>
        </div>
        @*<div class="list-util">
            <div class="wrap-util">
                <div class="head-util">
                    <span class="hh-text"></span>ทางลัด<span class="hh-ex">ดูทั้งหมด</span>
                </div>
                <div class="body-util t15">
                    <div class="list-body-util">
                        <span class="bb-text"><img src="~/images/home/c1.png"><span class="tt"></span>แผนงานในแผนก</span><span class="bb-amount">10</span>
                    </div>
                    <div class="list-body-util">
                        <span class="bb-text"><img src="~/images/home/c2.png"><span class="tt"></span>ศูนย์รวมข้อมูล</span><span class="bb-amount">10</span>
                    </div>
                    <div class="list-body-util">
                        <span class="bb-text"><img src="~/images/home/c3.png"><span class="tt"></span>เตือนเหตุการณ์</span><span class="bb-amount">10</span>
                    </div>
                    <div class="list-body-util">
                        <span class="bb-text"><img src="~/images/home/c4.png"><span class="tt"></span>ข้อมูลรหัสปิด</span><span class="bb-amount">10</span>
                    </div>
                    <div class="list-body-util">
                        <span class="bb-text"><img src="~/images/home/c5.png"><span class="tt"></span>ข้อมูลโครงสร้างระบบ</span><span class="bb-amount">10</span>
                    </div>
                </div>
            </div>
        </div>
        <div class="list-util">
            <div class="wrap-util">
                <div class="head-util">
                    <span class="hh-text"></span>กลุ่ม<span class="hh-ex">ดูทั้งหมด</span>
                </div>
                <div class="body-util t15">
                    <div class="list-body-util">
                        <span class="bb-text"><img src="~/images/home/g1.png"><span class="tt"></span>ดูหนังฟังเพลง</span><span class="bb-amount">10</span>
                    </div>
                    <div class="list-body-util">
                        <span class="bb-text"><img src="~/images/home/g2.png"><span class="tt"></span>สัปเพเหระ</span><span class="bb-amount">10</span>
                    </div>
                    <div class="list-body-util">
                        <span class="bb-text"><img src="~/images/home/g3.png"><span class="tt"></span>แบ่งปันกันเอง</span><span class="bb-amount">10</span>
                    </div>
                    <div class="list-body-util">
                        <span class="bb-text"><img src="~/images/home/g4.png"><span class="tt"></span>Sportman Can do</span><span class="bb-amount">10</span>
                    </div>
                    <div class="list-body-util">
                        <span class="bb-text"><img src="~/images/home/g5.png"><span class="tt"></span>ช้อปปิ้ง</span><span class="bb-amount">10</span>
                    </div>
                </div>
            </div>
        </div>*@
    </div>
</div>
