set colsep ,
set feedback off
set heading off
set trimout on
set linesize 200
spool C:\work\xiehe\SCM\wuliao.csv
select '"' || id || '","' ||  code || '","' ||  name || '","' ||  matnr || '","' ||  mtart || '","' ||  meins || '","' ||  mseht || '","' ||  maktx || '","' ||  zeinr || '","' ||  normt || '","' ||  freeuse1 || '","' ||  freeuse2 || '","' ||  freeuse3 || '","' ||  comments || '","' ||  state || '","' ||  create_user_id || '","' ||  create_time || '","' ||  create_depart_id || '","' ||  modify_user_id || '","' ||  modify_time || '","' ||  modify_depart_id || '","' ||  data_timestamp || '","' ||  data_organise_id || '","' ||  bklas || '"' from SCM_D_HRPMATER;
spool off
exit

