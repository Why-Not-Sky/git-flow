recruitment services
makeOffer(party_id, position_id)
{
    //[1.0.1-2017/01/06 sky-on-air-2016@gss fixed 未註記該職缺已經提供
  exec_sql('update vacancy set status='offered' where position_id=' & position_id)
}