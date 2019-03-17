." here we are inside pr101.fs" cr
199 133 88 55 33 .s ."  17 Mar 01:27 UTC" cr
." non-locally modded." cr
." words:  bwf - basic workflow" cr cr
: bwf ." Basic workflow:" cr
      ." 1. Edit on host PC ; gforth ./thisfile.fs to test" cr
      ." 2. git commit ; git push" cr
      ." 3. arm: filemgr: erase/rename existing file" cr
      ." 4. arm: FastHub: download revised .fs" cr
      ." 5. arm: gforth:  test" cr ;
0 [IF]
\ comment
[THEN]
