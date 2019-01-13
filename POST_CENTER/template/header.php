<?php
	$PAGE_VAR = array('css' =>array(),'js'=>array());
	$PAGE_VAR["js"][] = "common";
?>
<!DOCTYPE html>
<html>
	<head>
		<title></title>
		<meta charset="UTF-8">
		<meta http-equiv="X-UA-Compatible" content="IE=edge">
		<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
		<meta name="viewport" content="width=device-width, initial-scale=1">
		<?php
			$CORE_VAR = array('css' =>array(),'js'=>array());
			$CORE_VAR["css"][] = "fonts";
			$CORE_VAR["css"][] = "icomoon/styles";
			$CORE_VAR["css"][] = "bootstrap.min";
			$CORE_VAR["css"][] = "bootstrap_limitless.min";
			$CORE_VAR["css"][] = "layout.min";
			$CORE_VAR["css"][] = "components.min";
			$CORE_VAR["css"][] = "colors.min";
			$CORE_VAR["css"][] = "icomoon";
			$CORE_VAR["js"][] = "jquery-3.3.1.min";
			$CORE_VAR["js"][] = "bootstrap.bundle.min";

			$created_by = "This is example, please fill you name.";
			echo " <meta name='created_by' content='$created_by'>";
			echo '<script type="text/javascript"> var base_url ="'.WEB_META_BASE_URL.'";base_url_lang="'.WEB_META_BASE_URL.LANG.'/";var lang="'.LANG.'";</script>';
			foreach ($CORE_VAR["css"] as $key => $value) {
				echo '<link rel="stylesheet" type="text/css" href="'.WEB_META_BASE_URL.'css/'.$value.'.css"/>';
			}
			foreach ($CORE_VAR["js"] as $key => $value) {
				echo '<script type="text/javascript" src="'.WEB_META_BASE_URL.'js/'.$value.'.js"></script>';
			}
		?>
	</head>
	<body>
		<header>
			<section id="header">
				<div class="wrap-header">
					<div class="list-left">
						<div class="menu"></div><a class="logo-site" href="<?=WEB_META_BASE_URL?>"><img src="<?=WEB_META_BASE_URL?>Images/home/logo.svg"></a><span class="text-e">POST ยา</span>
					</div>
					<div class="list-sub-menu"><form id="search"><input name="search" type="text"></form><div class="sub-menu search"></div><div class="sub-menu noti">
					<div class="status red"></div>
					<div class="contain-sub-extend noti-extend">
						<div class="wrap-sub-extend">
							<div class="sub-extend-header">
								<div class="tt hh">เตือนเหตุการณ์</div><div class="ta hh-ex">ดูทั้งหมด</div>
							</div>
							<div class="sub-extend-body">
								<div class="remind">
									<a href="https://www.google.co.th/" class="list-tt">
										<div class="tt">ประชุมฝ่ายบริหาร</div><div class="ta">Today</div>
									</a>
									<a class="list-tt">
										<div class="tt">ประชุมฝ่ายแผนก</div><div class="ta">Next 2 Day</div>
									</a>
									<a class="list-tt">
										<div class="tt">ซ้อมหนีไฟ</div><div class="ta">Next 3 Day</div>
									</a>
									<a class="list-tt">
										<div class="tt">ประเมินบุคลากร</div><div class="ta">Next Week</div>
									</a>
								</div>
								<div class="activity">
									<a class="list-act" href="https://www.google.co.th/" title="www.google.co.th" target="_blank">
										<div class="wrap-list-act">
											<img class="profile-small" src="<?=WEB_META_BASE_URL?>Images/home/pp.png"><div class="wrap-text-act"><span class="t15 name">แมรี่</span> <span class="atslug">@mari</span> <div class="action t13">ได้แสดงความคิดเห็นเกี่ยวกับคุณ</div>
										</div>
									</div>
								</a>
								<a class="list-act" href="https://www.google.co.th/" title="www.google.co.th" target="_blank">
									<div class="wrap-list-act">
										<img class="profile-small" src="<?=WEB_META_BASE_URL?>Images/home/pp.png"><div class="wrap-text-act"><span class="t15 name">แมรี่</span> <span class="atslug">@mari</span> <div class="action t13">ได้แสดงความคิดเห็นเกี่ยวกับคุณ</div>
									</div>
								</div>
							</a>
							<a class="list-act" href="https://www.google.co.th/" title="www.google.co.th" target="_blank">
								<div class="wrap-list-act">
									<img class="profile-small" src="<?=WEB_META_BASE_URL?>Images/home/pp.png"><div class="wrap-text-act"><span class="t15 name">แมรี่</span> <span class="atslug">@mari</span> <div class="action t13">ได้แสดงความคิดเห็นเกี่ยวกับคุณ</div>
								</div>
							</div>
						</a>
					</div>
				</div>
				<div class="sub-extend-footer">
					ดูทั้งหมด
				</div>
			</div>
			</div>
			</div><div class="sub-menu list-panel">
			<div class="contain-sub-extend list-panel-extend">
			<div class="wrap-sub-extend">
			<div class="sub-extend-body">
				<div data-target="i1" class="item-list ic1">
					<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset%2010.png">
					<div class="tt t13">ผลิตภัณฑ์สุขภาพ</div>
				</div>
				<div data-target="i2" class="item-list">
					<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset%2020.png">
					<div class="tt t13">ลักษณะ การทำงาน/คำขอ ภายใต้ผลิตภัณฑ์</div>
				</div>
				<div data-target="i3" class="item-list">
					<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset%20170.png">
					<div class="tt t13">กลุ่ม<br />งานด่าน</div>
				</div>
				<div class="contain-nest-item-list i1">
					<div class="no-bot item-list">
						<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset 130.png">
						<div class="tt t13">เครื่องมือแพทย์<br />(MDC)</div>
					</div>
					<div class="no-bot item-list">
						<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset 140.png">
						<div class="tt t13">เครื่องสำอาง<br />(CMT)</div>
					</div>
					<div class="no-bot item-list">
						<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset 260.png">
						<div class="tt t13">ยา<br />(DRUG)</div>
					</div>
					<div class="no-bot item-list clear-left">
						<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset 270.png">
						<div class="tt t13">วัตถุเสพติด<br />(NCT)</div>
					</div>
					<div class="no-bot item-list">
						<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset 380.png">
						<div class="tt t13">วัตถุอันตราย<br />(TXC)</div>
					</div>
					<div class="no-bot item-list">
						<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset 390.png">
						<div class="tt t13">อาหาร<br />(FOOD)</div>
					</div>
					<div class="clearfix"></div>
				</div>
				<div class="contain-nest-item-list i2">
					<div data-target="ii1" class="no-bot item-list section_2 ic201">
						<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset 120.png">
						<div class="tt t13">ระบบจองคิว</div>
					</div>
					<div data-target="ii2" class="no-bot item-list section_2 ic202">
						<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset 150.png">
						<div class="tt t13">คำขออนุมัติ<br />เกี่ยวกับ<br />สถานที่</div>
					</div>
					<div data-target="ii3" class="no-bot item-list section_2">
						<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset 250.png">
						<div class="tt t13">คำขออนุมัติเกี่ยวกับผลิตภัณฑ์</div>
					</div>
					<div class="section_item_list_3 ii2">
						<ul class="item_list-3">
							<li>คำขอตรวจสถานที่</li>
							<li>ผลิต</li>
							<li>นำเข้า</li>
							<li>ขาย</li>
							<li>ครอบครอง / เก็บ</li>
						</ul>
					</div>
					<div class="section_item_list_3 ii3">
						<ul class="item_list-3">
							<li>ทะเบียน / ใบอนุญาต</li>
							<li>ผลิต</li>
							<li>นำเข้า</li>
							<li>ครอบครอง</li>
							<li>รายละเอียดผลิตภัณฑ์</li>
							<li>เพื่อการส่งออก</li>
						</ul>
					</div>
					<div data-target="ii4" class="no-bot item-list section_2 clear-left ic204">
						<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset 280.png">
						<div class="tt t13">คำขอต่ออายุ</div>
					</div>
					<div data-target="ii5" class="no-bot item-list section_2">
						<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset 370.png">
						<div class="tt t13">คำขอใบแทน</div>
					</div>
					<div data-target="ii6" class="no-bot item-list section_2 ic206">
						<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset 400.png">
						<div class="tt t13">คำขอแก้ไข / เปลี่ยนแปลง</div>
					</div>
					<div class="section_item_list_3 ii4">
						<ul class="item_list-3">
							<li>สถานที่</li>
							<li>ผลิตภัณฑ์</li>
						</ul>
					</div>
					<div class="section_item_list_3 ii6">
						<ul class="item_list-3">
							<li>รายละเอียดผลิตภัณฑ์</li>
							<li>สถานที่</li>
							<li>อื่นๆ</li>
						</ul>
					</div>
					<div data-target="ii7" class="no-bot item-list section_2 clear-left">
						<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset 30.png">
						<div class="tt t13">คำขอวินิจฉัย<br />ผลิตภัณฑ์</div>
					</div>
					<div data-target="ii8" class="no-bot item-list section_2 ic208">
						<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset 110.png">
						<div class="tt t13">คำขอประเมิน<br />ความปลอดภัย<br />ของผลิตภัณฑ์</div>
					</div>
					<div data-target="ii9" class="no-bot item-list section_2 ic209">
						<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset 160.png">
						<div class="tt t13">คำขออนุมัติสูตร</div>
					</div>
					<div data-target="ii10" class="no-bot item-list section_2 clear-left ic210">
						<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset 240.png">
						<div class="tt t13">เพิ่มสาร / ส่วนประกอบ</div>
					</div>
					<div data-target="ii11" class="no-bot item-list section_2">
						<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset 290.png">
						<div class="tt t13">คำขอใบรับรอง<br />(CER)</div>
					</div>
					<div data-target="ii12" class="no-bot item-list section_2 ic212">
						<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset 360.png">
						<div class="tt t13">คำขอใบอนุญาต<br />โฆษณา (AD)</div>
					</div>
					<div data-target="ii13" class="no-bot item-list section_2 clear-left ic213">
						<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset 410.png">
						<div class="tt t13">ชำระเงิน</div>
					</div>
					<div data-target="ii14" class="no-bot item-list section_2 ic214">
						<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset 40.png">
						<div class="tt t13">ระบบค้นหาข้อมูล (Search)</div>
					</div>
					<div data-target="ii15" class="no-bot item-list section_2">
						<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset 100.png">
						<div class="tt t13">ระบบพิกัด<br />(GIS)</div>
					</div>
					<div class="section_item_list_3 ii13">
						<ul class="item_list-3">
							<li>ข้อมูลใบสั่ง</li>
							<li>ข้อมูลใบเสร็จ</li>
						</ul>
					</div>
					<div class="clearfix"></div>
				</div>
				<div class="contain-nest-item-list i3">
					<div class="no-bot item-list section_2">
						<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset 230.png">
						<div class="tt t13">การแจ้ง รายละเอียดนำเข้าผลิตภัณฑ์สุขภาพ (LPI)</div>
					</div>
					<div class="no-bot item-list section_2">
						<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset 300.png">
						<div class="tt t13">ระบบตรวจร่วม (NSW)</div>
					</div>
					<div class="clearfix"></div>
				</div>
				<div data-target="i4" class="item-list clear-left ic4">
					<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset 350.png">
					<div class="tt t13">ระบบอื่นๆ</div>
				</div>
				<div data-target="i5" class="item-list ic5">
					<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset 210.png">
					<div class="tt t13">กลุ่มผู้ใช้งาน</div>
				</div>
				<div class="contain-nest-item-list i4">
					<div class="no-bot item-list section_2 ic401">
						<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset 420.png">
						<div class="tt t13">ระบบ<br />กำหนดสิทธิ์<br />(Permission)</div>
					</div>
					<div class="no-bot item-list section_2 ic402">
						<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset 50.png">
						<div class="tt t13">การเงินการคลัง<br />(BG)</div>
					</div>
					<div class="no-bot item-list section_2">
						<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset 90.png">
						<div class="tt t13">สารบรรณ<br />(eDOC)</div>
					</div>
					<div class="no-bot item-list section_2 clear-left">
						<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset 180.png">
						<div class="tt t13">ระบบจัดประชุม<br />(eMeeting)</div>
					</div>
					<div class="no-bot item-list section_2 ic405">
						<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset 220.png">
						<div class="tt t13">ระบบติดตามผล<br />การพิจารณา<br />(eTracking)</div>
					</div>
					<div class="no-bot item-list section_2 ic406">
						<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset 310.png">
						<div class="tt t13">ระบบศูนย์<br />ปฏิบัติข้อมูล<br />ระดับกรม(DOC)</div>
					</div>
					<div class="no-bot item-list section_2 clear-left ic407">
						<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset 340.png">
						<div class="tt t13">ออกบัตร<br />พนักงาน<br />(OPM)</div>
					</div>
					<div class="no-bot item-list section_2">
						<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset 430.png">
						<div class="tt t13">ระบบพัฒนา<br />บุคคลากร<br />(HRD)</div>
					</div>
					<div class="no-bot item-list section_2">
						<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset 450.png">
						<div class="tt t13">ระบบรายงาน<br />การกระจายของ<br />ผลิตภัณฑ์สุขภาพ (BigData)</div>
					</div>
					<div class="no-bot item-list section_2 clear-left">
						<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset 80.png">
						<div class="tt t13">ระบบติดตามและประเมินผล (KPI)</div>
					</div>
					<div class="no-bot item-list section_2">
						<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset 190.png">
						<div class="tt t13">ระบบทำแทน</div>
					</div>
					<div class="clearfix"></div>
				</div>
				<div class="contain-nest-item-list i5">
					<div data-target="ii16" class="no-bot item-list section_2">
						<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset 320.png">
						<div class="tt t13">ผู้ประกอบการ</div>
					</div>
					<div data-target="ii17" class="no-bot item-list section_2">
						<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset 330.png">
						<div class="tt t13">ประชาชน</div>
					</div>
					<div data-target="ii18" class="no-bot item-list section_2">
						<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset 440.png">
						<div class="tt t13">ผู้ประกอบวิชาชีพ</div>
					</div>
					<div class="section_item_list_3 ii16">
						<ul class="item_list-3">
							<li>ผลิต</li>
							<li>ข้อมูลใบเสร็จ</li>
							<li>จำหน่าย</li>
							<li>ตัวแทน / ผู้รับมอบอำนาจ</li>
						</ul>
					</div>
					<div data-target="ii19" class="no-bot item-list section_2 clear-left">
						<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset 60.png">
						<div class="tt t13">จนท. อย.</div>
					</div>
					<div data-target="ii20" class="no-bot item-list section_2">
						<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset 70.png">
						<div class="tt t13">จนท. สสจ.</div>
					</div>
					<div class="no-bot item-list section_2">
						<img src="<?=WEB_META_BASE_URL?>Images/home/icon/Asset 200.png">
						<div class="tt t13">จนท.ภายนอก</div>
					</div>
					<div class="section_item_list_3 ii19">
						<ul class="item_list-3">
							<li>Pre - ประสาน ผปก. รับเรื่องคำขอต่างๆ</li>
							<li>Post - พิจารณาเรื่องที่ได้รับ</li>
							<li>พัฒนาระบบ</li>
						</ul>
					</div>
					<div class="section_item_list_3 ii20">
						<ul class="item_list-3">
							<li>Pre - ประสาน ผปก. รับเรื่องคำขอต่างๆ</li>
							<li>Post - พิจารณาเรื่องที่ได้รับ</li>
							<li>จำหน่าย</li>
							<li>ตัวแทน / ผู้รับมอบอำนาจ</li>
						</ul>
					</div>
					<div class="clearfix"></div>
				</div>
			</div>
			<div class="sub-extend-footer">
				ดูทั้งหมด
			</div>
			</div></div>
			</div><div class="sub-menu sign-out"><i class="fas fa-sign-out-alt icon"></i></div>
			</div>
			</div>
			<div class="line-header"></div>
			</section>
		</header>
		<div id="main-content">
			<div class="wrap-main-content">
				<div id="page">
					<div class="content-overlay"></div>
				