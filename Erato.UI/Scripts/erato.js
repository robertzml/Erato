
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
	
	var handleInitEditTable = function($dom, $new) {
		function restoreRow(oTable, nRow) {
            var aData = oTable.fnGetData(nRow);
            var jqTds = $('>td', nRow);

            for (var i = 0, iLen = jqTds.length; i < iLen; i++) {
                oTable.fnUpdate(aData[i], nRow, i, false);
            }

            oTable.fnDraw();
        }

        function editRow(oTable, nRow, colLength) {
            var aData = oTable.fnGetData(nRow);
            var jqTds = $('>td', nRow);
			for(var i = 0; i < colLength; i++) {
				jqTds[i].innerHTML = '<input type="text" class="form-control input-small" value="' + aData[i] + '">';
			}           
            jqTds[colLength - 2].innerHTML = '<a class="edit" href="">保存</a>';
            jqTds[colLength - 1].innerHTML = '<a class="cancel" href="">取消</a>';
        }

        function saveRow(oTable, nRow, colLength) {
            var jqInputs = $('input', nRow);
			for (var i = 0; i < colLength; i++) {
				oTable.fnUpdate(jqInputs[i].value, nRow, i, false);
			}          
            oTable.fnUpdate('<a class="edit" href="">编辑</a>', nRow, colLength - 2, false);
            oTable.fnUpdate('<a class="delete" href="">删除</a>', nRow, colLength - 1, false);
            oTable.fnDraw();
        }

        function cancelEditRow(oTable, nRow) {
            var jqInputs = $('input', nRow);
            oTable.fnUpdate(jqInputs[0].value, nRow, 0, false);
            oTable.fnUpdate(jqInputs[1].value, nRow, 1, false);
            oTable.fnUpdate(jqInputs[2].value, nRow, 2, false);
            oTable.fnUpdate(jqInputs[3].value, nRow, 3, false);
			oTable.fnUpdate(jqInputs[4].value, nRow, 4, false);
            oTable.fnUpdate('<a class="edit" href="">Edit</a>', nRow, 5, false);
            oTable.fnDraw();
        }

        var table = $dom;

        var oTable = table.dataTable({
            "dom": "t",

            "lengthMenu": [
                [5, 15, 20, -1],
                [5, 15, 20, "All"] // change per page values here
            ],
            // set the initial value
            "pageLength": 10,

            "language": {
                "lengthMenu": " _MENU_ records"
            },

            "order": [
                [0, "asc"]
            ] // set first column as a default sort by asc
        });
    
        var nEditing = null;
        var nNew = false;
		var colLength = oTable.api().columns()[0].length;
		
        $new.click(function (e) {
            e.preventDefault();

            if (nNew && nEditing) {
                if (confirm("Previose row not saved. Do you want to save it ?")) {
                    saveRow(oTable, nEditing, colLength); // save
                    $(nEditing).find("td:first").html("Untitled");
                    nEditing = null;
                    nNew = false;

                } else {
                    oTable.fnDeleteRow(nEditing); // cancel
                    nEditing = null;
                    nNew = false;
                    
                    return;
                }
            }

			var emptyRow = new Array(colLength);
			for (var i = 0; i < emptyRow.length; i++) {
				emptyRow[i] = '';
			}
            var aiNew = oTable.fnAddData(emptyRow);
            var nRow = oTable.fnGetNodes(aiNew[0]);
            editRow(oTable, nRow, colLength);
            nEditing = nRow;
            nNew = true;
        });

        table.on('click', '.delete', function (e) {
            e.preventDefault();

            if (confirm("是否确认删除本行 ?") == false) {
                return;
            }

            var nRow = $(this).parents('tr')[0];
            oTable.fnDeleteRow(nRow);
            //alert("Deleted! Do not forget to do some ajax to sync with backend :)");
        });

        table.on('click', '.cancel', function (e) {
            e.preventDefault();
            if (nNew) {
                oTable.fnDeleteRow(nEditing);
                nEditing = null;
                nNew = false;
            } else {
                restoreRow(oTable, nEditing);
                nEditing = null;
            }
        });

        table.on('click', '.edit', function (e) {
            e.preventDefault();

            /* Get the row as a parent of the link that was clicked on */
            var nRow = $(this).parents('tr')[0];

            if (nEditing !== null && nEditing != nRow) {
                /* Currently editing - but not this row - restore the old before continuing to edit mode */
                restoreRow(oTable, nEditing);
                editRow(oTable, nRow, colLength);
                nEditing = nRow;
            } else if (nEditing == nRow && this.innerHTML == "Save") {
                /* Editing this row and want to save it */
                saveRow(oTable, nEditing, colLength);
                nEditing = null;
                alert("Updated! Do not forget to do some ajax to sync with backend :)");
            } else {
                /* No edit in progress - let's start one */
                editRow(oTable, nRow, colLength);
                nEditing = nRow;
            }
        });
	}
		
	
	var handleInitDatePicker = function($dom, today) {
		if (today == true) {
			$dom.datepicker({
				format: "yyyy-mm-dd",
				weekStart: 7,
				language: "zh-CN",
				autoclose: true,
				todayHighlight: true
			});
		} else {
			$dom.datepicker({
                format: "yyyy-mm-dd",
                weekStart: 7,
                language: "zh-CN",
                autoclose: true
            });
		}
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
		},
		
		initEditTable: function($dom, $new) {
			return handleInitEditTable($dom, $new);
		},

		initDatePicker: function($dom, today) {
			handleInitDatePicker($dom, today);
		}
	};
}();