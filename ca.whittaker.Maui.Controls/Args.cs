﻿namespace ca.whittaker.Maui.Controls;
public enum SiginButtonTypeEnum { Generic, Facebook, Linkedin, Google, Tiktok, Microsoft, Apple }
public enum FieldTypeEnum { Text, Email, Url, Chat, Username }
public enum ButtonStateEnum { Enabled, Disabled, Hidden }
public enum ChangeStateEnum { Changed, NotChanged }
public enum ValidationStateEnum { Valid, FormatError, RequiredFieldError }
public enum FormStateEnum { Enabled, Disabled, Hidden, Reset }
public enum ButtonSizeEnum { Normal = 24, Large = 48 }

public class HasChangesEventArgs : EventArgs
{
    public HasChangesEventArgs(bool hasChanged) => HasChanged = hasChanged;
    public bool HasChanged { get; }
}
public class HasFormChangesEventArgs : EventArgs
{
    public HasFormChangesEventArgs(FormStateEnum formState) => FormState = formState;
    public FormStateEnum FormState { get; }
}

public class ValidationDataChangesEventArgs : EventArgs
{
    public ValidationDataChangesEventArgs(bool isInvalid) => Invalid = isInvalid;
    public bool Invalid { get; }
}
