\ ." here we are inside pr101.fs" cr

222 133 99 88 55 $3e .s

."  17 Mar 01:55 UTC" cr

\ ." non-locally modded." cr
." words:  bwf - basic workflow" cr cr

: bwf cr cr ( -- )

    ." Basic workflow:" cr cr

    ."   1. pc:  edit pr101.fs ; gforth ./pr101.fs" cr
    ."           to test" cr
    ."   2. pc:  git commit ; git push" cr
    ."   3. arm: filemgr: rename existing file" cr
    ."   4. arm: FastHub: download revised .fs" cr
    ."   5. arm: gforth:  test" cr ;

0 [IF]
\ comment
[THEN]
