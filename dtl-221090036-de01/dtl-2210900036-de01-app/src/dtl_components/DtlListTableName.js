import React from 'react';

export default function DtlListTableName({ renderDtlListTableName, onDtlDelete, onDtlEdit }) {
    console.log("List:", renderDtlListTableName);

    // Hiển thị dữ liệu
    const dtlElementTableName = renderDtlListTableName.map((dtlItem, dtlIndex) => {
        return (
            <tr key={dtlIndex}>
                <td>{dtlItem.dtlId}</td>
                <td>{dtlItem.dtlTbName}</td>
                <td>{dtlItem.dtlTbEmail}</td>
                <td>{dtlItem.dtlTbPhone}</td>
                <td>{(dtlItem.dtlTbStatus === true || dtlItem.dtlTbStatus === "true") ? "Active" : "Non-Active"}</td>
                <td>
                    <button className='btn btn-success m-2' onClick={() => dtlHandleEdit(dtlItem)}>dtl-edit</button>
                    <button className='btn btn-danger' onClick={() => dtlHandleDelete(dtlItem.dtlId)}>dtl-delete</button>
                </td>
            </tr>
        );
    });

    const dtlHandleDelete = (dtlId) => {
        if (window.confirm('Bạn có muốn xóa dữ liệu dtlId ' + dtlId)) {
            onDtlDelete(dtlId);
        }
    };

    const dtlHandleEdit = (dtlOjTableName) => {
        onDtlEdit(dtlOjTableName);
    };

    return (
        <div>
            <h2>Danh sách thông tin ..</h2>
            <hr />
            <table className='table table-border'>
                <thead>
                    <tr>
                        <th>dtlId</th>
                        <th>dtlTbName</th>
                        <th>dtlTbEmail</th>
                        <th>dtlTbPhone</th>
                        <th>dtlTbStatus</th>
                        <th>dtl:chức năng</th>
                    </tr>
                </thead>
                <tbody>
                    {dtlElementTableName}
                </tbody>
            </table>
        </div>
    );
}
