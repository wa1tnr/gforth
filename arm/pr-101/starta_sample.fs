0 [IF]

  /storage/emulated/0/gforth/arm/gforth/site-forth/starta.fs
  md5sum starta.fs
  80c573...9c1b9b
 
 $ cat starta.fs (excerpted only):

 : t get-connection ;
 : lex s" /storage/emulated/0/xxxxxxxx.d/forth.d/job.fs" included ;
 ." load android" cr stdout flush-file throw
 require unix/android.fs

[THEN] 
