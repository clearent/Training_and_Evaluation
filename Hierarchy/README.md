Hierarchy Challenge
===================

Given data structured in the following way:


                                            Jim
                                            ---
                                            Age: 32
                                            Location: St. Louis
                                             |
                                             |
                   ----------------------------------------------------------
                   |                         |                              |
                 Donna                     Samantha                       Joseph
                 -----                     --------                       ------
                 Age: 27                   Age: 44                        Age: 51
                 Location: Poplar Bluff    Location: Carthage             Location: St. Louis
                  |                                                        |
                  |                                                        |
   ----------------------------------                      -------------------------------------------------------------------
   |                                |                      |                      |                      |                   |
   |                                |                      |                      |                      |                   |
 Henry                            Philip                 Carrie                 Devin                  Matthew             Ann
 -----                            ------                 ------                 -----                  -------             ---
 Age: 12                          Age: 9                 Age: 42                Age: 17                Age: 81             Age: 3
 Location: Poplar Bluff           Location: Paris        Location: Joplin       Location: St. Louis    Location: Baden     Location: St. Louis
                                                                                                           |
                                                                                                           |
                                                                                                          Luke
                                                                                                          ----
                                                                                                          Age: 33
                                                                                                          Location: St. Louis

stored in a table that looks like:

Name         Location                     Age
----         --------                     ---
Jim          St. Louis                    30
Donna        Poplar Bluff                 27
Samantha     Carthage                     44
Joseph       St. Louis                    51
Henry        Poplar Bluff                 12
Philip       Paris                         9
Carrie       Joplin                       42
Devin        St. Louis                    17
Matthew      Baden                        81
Ann          St. Louis                     3
Luke         St. Louis                    33

Do the following:

1.  Modify the table to store and reflect the relationship depicted above.
2.  Create queries to answer the following questions:
  A.  How many people are located in St. Louis?
  B.  What is the average age of all the descendants of Joseph?
  C.  Locate the first ancestor of Henry whose age is greater than 30.
  D.  List the ancestors of Luke in order of the furthest to the closest relative.
