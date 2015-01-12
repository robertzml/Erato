
var erato = function() {
	var handleTostarMessage = function(message) {
		
		toastr.options = {
			"closeButton": true,			
			"progressBar": true,
			"positionClass": "toast-top-center",
			"onclick": null,
			"showDuration": "300",
			"hideDuration": "1000",
			"timeOut": "5000",
			"extendedTimeOut": "1000",
			"showEasing": "swing",
			"hideEasing": "linear",
			"showMethod": "fadeIn",
			"hideMethod": "fadeOut"
		};
		toastr['info'](message);
	}

	var handleTopNavActive =  function($dom) {
		$('ul#top-nav').children().removeClass('active');	

		$dom.parent().addClass('active');
		$dom.append('<span class="selected"></span>');
	}

	/* init datatable with filter */
	var handleInitDatatable = function($dom) {
		var oTable = $dom.DataTable({
			"order": [],

			"lengthMenu": [
				[5, 10, 20, -1],
				[5, 10, 20, "All"] // change per page values here
			],
			// set the initial value
			"pageLength": 10,

			"pagingType": "bootstrap_full_number",

			"language": {
					"lengthMenu": "  _MENU_ 记录",
					"sLengthMenu": "每页 _MENU_ 条记录",
					"sInfo": "显示 _START_ 至 _END_ 共有 _TOTAL_ 条记录",
					"sInfoEmpty": "记录为空",
					"sInfoFiltered": " - 从 _MAX_ 条记录中",
					"sZeroRecords": "结果为空",
					"sSearch": "搜索:",
					"paginate": {
						"previous":"Prev",
						"next": "Next",
						"last": "Last",
						"first": "First"
					}
				},

			"dom": "<'row'<'col-md-6 col-sm-12'l><'col-md-6 col-sm-12'f>r><'table-scrollable't><'row'<'col-md-5 col-sm-12'i><'col-md-7 col-sm-12' p>>", // horizobtal scrollable datatable
			
			initComplete: function () {
				var api = this.api();
	 
				api.columns().indexes().flatten().each( function ( i ) {
					var column = api.column( i );
					if ($(column.footer()).attr('data-filter') == 'true') {
					
						var select = $('<select class="form-control"><option value=""></option></select>')
							.appendTo( $(column.footer()).empty() )
							.on( 'change', function () {
								var val = $.fn.dataTable.util.escapeRegex(
									$(this).val()
								);
		 
								column
									.search( val ? '^'+val+'$' : '', true, false )
									.draw();
							});
	 
						column.data().unique().sort().each( function ( d, j ) {
							var re = /<[^>]+>/;
							if (re.test(d)) {
								select.append('<option value="' + $(d).html() + '">' + $(d).html() + '</option>')
							} else {
								select.append('<option value="' + d + '">' + d + '</option>')
							}
						});
					}
				} );
			}
		});
		
		return oTable;
	}
	
	return {
		showMessage: function(message) {
			handleTostarMessage(message);
		},
	
		topNavActive: function($dom) {
            handleTopNavActive($dom);
        },

		initDatatable: function($dom) {
			return handleInitDatatable($dom);
		}
	};
}();