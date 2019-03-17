\ job.fs 15 March 2019

s" local_source.fs" included
." job.fs: local_source loaded." cr cr

0 [IF]

  The FastHub directory is simply the
  default download directory
  for FastHub.

  The file stored there (pr101.fs as
  of this writing) belongs elsewhere
  in the git structure, but (on the
  Android/arm device) is run from the
  FastHub directory (through inclusion
  that traces back to starta.fs) ..
  for convenience.

  See (immediately) below for the code
  that includes pr101.fs on the running
  (workflow-enhanced) Android system.

  Just be aware that pr101.fs (and any
  project code that is developed, later)
  won't be stored on git under a 'FastHub'
  subdirectory.

[THEN]
s" ../../FastHub/pr101.fs" included
." job.fs: pr101 loaded." cr cr
