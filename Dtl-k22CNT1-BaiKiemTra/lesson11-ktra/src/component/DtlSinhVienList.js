import React from 'react'
import axios from '../api/DtlApi'
export default function DtlSinhVienList({renderDtlSinhVienList,onDtlDelete}) {
    console.log("DtlSinhVienList:",renderDtlSinhVienList);
    //hieem thij du lieu
    let dtlElementUser = renderDtlSinhVienList.map((dtlUser,index)=>{
        return(
             <tr key={index}>
                <td>{dtlUser.DtlMaSV}</td>
                <td>{dtlUser.DtlMaSV}</td>
                <td>{dtlUser.DtlTenSV }</td>
                <td>{dtlUser.DtlPhai}</td>
                <td>{dtlUser.DtlNgaysinh}</td>
                <td>{dtlUser.DtlNoisinh}</td>
                <td>{dtlUser.DtlMaKH}</td>
                <td>{dtlUser.DtlHocbong}</td>
                <td>{dtlUser.DtlDiemtrungbinh}</td>
                <td>
                  <button className='btn btn-danger' onClick={()=>dtlHandleDelete(dtlUser)}> Delete </button>
                </td>
            </tr>
            
        )
        
    })
    const dtlHandleDelete =  async (param)=>{
      if(window.confirm('Bạn có muốn xóa thật không?')){
          const dtlRes = await axios.delete("dtlUsers/"+param.id);
      }
      onDtlDelete();
    }

  return (
    <div className='row'>
      <div className='col-md-12'>
      <table className='table table-borderd'>
        <head>
        <tr>
                <td>DtlMaSV</td>
                <td>DtlMaSV</td>
                <td>DtlTenSV</td>
                <td>DtlPhai</td>
                <td>DtlNgaysinh</td>
                <td>DtlNoisinh</td>
                <td>DtlMaKH</td>
                <td>DtlHocbong</td>
                <td>DtlDiemtrungbinh</td>
                <td></td>
            </tr>
        </head>
        <body>
           
            {dtlElementUser}
        </body>


      </table>
      </div>
    </div>
  )
}
