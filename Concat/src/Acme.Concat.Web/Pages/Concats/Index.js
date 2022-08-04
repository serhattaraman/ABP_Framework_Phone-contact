$(function () {
    var l = abp.localization.getResource('Concat');
    var createModal = new abp.ModalManager(abp.appPath + 'Concats/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Concats/EditModal');


    var dataTable = $('#ConcatsTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(acme.concat.concats.concat.getList),
            columnDefs: [
                {
                    title: l('Actions'),
                    rowAction: {
                        items:
                        [
                            {
                                text: l('Edit'),
                                visible:abp.auth.isGranted('Concat.Concats.Edit'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('Concat.Concats.Delete'),
                                confirmMessage: function (data) {
                                    return l(
                                        'ConcatDeletionConfirmationMessage',
                                        data.record.name
                                    );
                                },
                                action: function (data) {
                                    acme.concat.concats.concat
                                        .delete(data.record.id)
                                        .then(function () {
                                            abp.notify.info(
                                                l('SuccessfullyDeleted')
                                            );
                                            dataTable.ajax.reload();
                                        });
                                }
                            }
                        ]
                    }
                },


                {

                    title: l('Name'),
                    data: "name"
                },
                {
                    title: l('lastName'),
                    data:"lastName"
                },
                {
                    title: l('Type'),
                    data: "type",
                    render: function (data) {
                        return l('Enum:ConcatType:' + data);
                    }
                },
                {
                    title: l('PublishDate'),
                    data: "publishDate",
                    render: function (data) {
                        return luxon
                            .DateTime
                            .fromISO(data, {
                                locale: abp.localization.currentCulture.name
                            }).toLocaleString();
                    }
                },
                {
                    title: l('phone'),
                    data: "phone"
                },
                {
                    title: l('CreationTime'), data: "creationTime",
                    render: function (data) {
                        return luxon
                            .DateTime
                            .fromISO(data, {
                                locale: abp.localization.currentCulture.name
                            }).toLocaleString(luxon.DateTime.DATETIME_SHORT);
                    }
                }
            ]
        })
    );
    createModal.onResult(function () {
        dataTable.ajax.reload();
    });
    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewEmployerButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});