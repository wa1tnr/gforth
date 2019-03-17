\ pr101.fs

211 188 77 66 44 $3a .s

."  17 Mar 04:57 UTC" cr

." words:  bwf   - basic workflow"    cr
."         tryaa - something to try"  cr
."         ncr   - cr n times"        cr cr

: ncr ( n -- ) \ emit: cr x n
  for cr next ;

: bwf cr cr ( -- )

    ." Basic workflow:" cr cr

    ."   1. pc:  edit pr101.fs ; gforth ./pr101.fs" cr
    ."           to test" cr
    ."   2. pc:  git commit ; git push" cr
    ."   3. arm: filemgr: rename existing file" cr
    ."   4. arm: FastHub: download revised .fs" cr
    ."   5. arm: gforth:  test" cr ;

: tryaa cr ( -- )
    ." Try this:" cr cr
    ." 91 27 emit emit "
    ." 56 emit "         \  '8'     48:0 49:1 50:2 .. 57:9 here
\   ." 48 49 emit emit " \ '10'     gives 'ESC[10A' in output to terminal (move up 10 lines)
    ." 65 emit cr 70 spaces 7 ncr" cr ;

0 [IF]
    RESULT: works on Linux PC host because ansi.sys (vt220?) style escapes work there.
            doesn't work on gforth running on the arm handheld, because that
            environment uses a different screen/terminal emulation.

            Instead, gforth/arm shows the escape codes on-screen.
[THEN]
