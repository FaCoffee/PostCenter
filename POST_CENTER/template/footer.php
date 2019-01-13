				</div>
			</div>
		</div>
		<footer> 
			<p style="text-align: center;">FOOTER SECTION</p>
		</footer>
	<?php
		foreach ($PAGE_VAR["css"] as $key => $value) {
			echo '<link rel="stylesheet" type="text/css" href="'.WEB_META_BASE_URL.'css/'.$value.'.css"/>';
		}
		foreach ($PAGE_VAR["js"] as $key => $value) {
			echo '<script type="text/javascript" src="'.WEB_META_BASE_URL.'js/'.$value.'.js"></script>';
		}
	?>
	</body>
</html>