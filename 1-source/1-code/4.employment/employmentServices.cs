#employment services
#檢查是否為以前任職員工？
getEmployment(party_id, position_id)
{
  bug-fixed on release 1.0 (pre)
  //[1.0.1-2017/01/06 toshiba@gss fixed 未判斷聘用狀況、在職離職、留停]


  //[1.0.1-2017/01/06 sky-on-air-2016@gss fixed 有多次進出時的錯誤]
  lastRecord = exec_sql('select max() from employment')

}
