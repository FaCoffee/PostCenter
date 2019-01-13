<?php
	include 'header.php';
	$file = ABSPATH . 'controller/'.WEB_URI.'.php';

	error_reporting(E_ALL);
	ini_set('display_errors', 1);
	date_default_timezone_set("Asia/Bangkok");
	parse_str(substr(WEB_URI,stripos(WEB_URI,"?")+1), $output);

	if ( file_exists( $file ) ) {
		include  ABSPATH . "template/menu_left.php";
		include  $file;
	}else{
		include '404.php';
	}
?>

<?php
	include 'footer.php';
?>