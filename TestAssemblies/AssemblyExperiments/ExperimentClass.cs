﻿using PropertyChanged;

[ImplementPropertyChanged]
public class ClassWithNotifyInChildByAttribute : ParentClass
{
    public string Property1 { get; set; }
}

public class ParentClass
{
}