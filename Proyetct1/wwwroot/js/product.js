var dataTable;
$(document).ready(function () {
    loadDataTable();
});

function loadDataTable()
{
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/admin/product/getall' },
        "columns": [
            { data: 'title', "width": "25%" },
            { data: 'barcode', "width": "15%" },
            { data: 'listPrice', "width": "10%" },
            { data: 'seller', "width": "20%" },
            { data: 'category.name', "width": "35%" },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="w-75 btn-group" role="group">
                        <a href="/admin/product/upsert?id=${data}" class="btn btn-primary mx-2"> <i class="bi bi-pencil-square"></i> Editar </a>
                        <a OnClick=Delete('/admin/product/delete/${data}') class="btn btn-danger mx-2"> <i class="bi bi-trash"></i> Eliminar </a>
                    </div>`
                },
                "width": "35%"
            }
        ]
    });
}

function Delete(url) {
    Swal.fire({
        title: 'Deseas eliminar el producto?',
        text: "Este cambio no podra revertirse",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Si, Eliminalo'
    }).then((result) => {
        $.ajax({
            url: url,
            type: 'Delete',
            success: function (data) {
                dataTable.ajax.reload();
                toastr.success(data.message);
            }
        })
    })
}
