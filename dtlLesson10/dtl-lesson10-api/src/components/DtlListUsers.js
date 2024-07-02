import React from 'react'
import axios from '../api/dtlApi'
export default function DtlListUsers({renderDtlListUsers,onDtlDelete}) {
    console.log("DtlListUsers:",renderDtlListUsers);
    //hieem thij du lieu
    let dtlElementUser = renderDtlListUsers.map((dtlUser,index)=>{
        return(
             <tr key={index}>
                <td>{dtlUser.id}</td>
                <td>{dtlUser.UserName}</td>
                <td>{dtlUser.Password}</td>
                <td>{dtlUser.Email}</td>
                <td>{dtlUser.Phone}</td>
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
                <td>Id</td>
                <td>UserName</td>
                <td>Password</td>
                <td>Email</td>
                <td>Phone</td>
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
