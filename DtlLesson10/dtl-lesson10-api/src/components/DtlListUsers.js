import React from 'react'

export default function DtlListUsers({renderDtlListUsers}) {
    console.log("DtlListUsers:",renderDtlListUsers)
    //hieem thij du lieu
    let dtlElementUser = renderDtlListUsers.map((dtlUser,index)=>{
        return(
            <>
             <tr>
                <td>{dtlUser.id}</td>
                <td>{dtlUser.UserName}</td>
                <td>{dtlUser.Password}</td>
                <td>{dtlUser.Email}</td>
                <td>{dtlUser.Phone}</td>
                <td>...</td>
            </tr>
            </>
        )
    })

  return (
    <div className='row'>
      <table className='table table-borderd'>
        <head>
            <dtlElementUser />
        </head>
        <body>
            <tr>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
        </body>


      </table>
    </div>
  )
}
