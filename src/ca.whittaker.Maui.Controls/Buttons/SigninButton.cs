﻿namespace ca.whittaker.Maui.Controls.Buttons;

public class SigninButton : ButtonBase
{
    public static readonly BindableProperty SigninButtonStateProperty = BindableProperty.Create(
        propertyName: nameof(SigninButtonState),
        returnType: typeof(ButtonStateEnum),
        declaringType: typeof(ButtonBase),
        defaultValue: ButtonStateEnum.Disabled,
        defaultBindingMode: BindingMode.OneWay,
        propertyChanged: OnButtonStateChanged);

    public ButtonStateEnum SigninButtonState
    {
        get => (ButtonStateEnum)GetValue(SigninButtonStateProperty);
        set => SetValue(SigninButtonStateProperty, value);
    }

    private static void OnButtonStateChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (oldValue != newValue)
            if (bindable is ButtonBase buttonBase)
            {
                buttonBase.SetButtonState((ButtonStateEnum)newValue);
            }
    }


    public static readonly BindableProperty SigninButtonTypeProperty = BindableProperty.Create(
        propertyName: nameof(SigninButtonType),
        returnType: typeof(SiginButtonTypeEnum),
        declaringType: typeof(ButtonBase),
        defaultValue: SiginButtonTypeEnum.Generic,
        defaultBindingMode: BindingMode.OneWay,
        propertyChanged: OnButtonTypeChanged);

    private static void OnButtonTypeChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (oldValue != newValue)
            if (bindable is SigninButton signinButton)
            {
                signinButton.SetSigninButtonType((SiginButtonTypeEnum)newValue);
            }
    }

    public SiginButtonTypeEnum SigninButtonType
    {
        get => (SiginButtonTypeEnum)GetValue(SigninButtonTypeProperty);
        set => SetValue(SigninButtonTypeProperty, value);
    }

    public void SetSigninButtonType(SiginButtonTypeEnum buttonType)
    {
        switch (buttonType)
        {
            case SiginButtonTypeEnum.Facebook:
                SetValue(SigninButtonTypeProperty, SiginButtonTypeEnum.Facebook);
                base._baseButtonType = BaseButtonTypeEnum.Facebook;
                break;
            case SiginButtonTypeEnum.Google:
                SetValue(SigninButtonTypeProperty, SiginButtonTypeEnum.Google);
                base._baseButtonType = BaseButtonTypeEnum.Google;
                break;
            case SiginButtonTypeEnum.Linkedin:
                SetValue(SigninButtonTypeProperty, SiginButtonTypeEnum.Linkedin);
                base._baseButtonType = BaseButtonTypeEnum.Linkedin;
                break;
            case SiginButtonTypeEnum.Tiktok:
                SetValue(SigninButtonTypeProperty, SiginButtonTypeEnum.Tiktok);
                base._baseButtonType = BaseButtonTypeEnum.Tiktok;
                break;
            case SiginButtonTypeEnum.Microsoft:
                SetValue(SigninButtonTypeProperty, SiginButtonTypeEnum.Microsoft);
                base._baseButtonType = BaseButtonTypeEnum.Microsoft;
                break;
            case SiginButtonTypeEnum.Apple:
                SetValue(SigninButtonTypeProperty, SiginButtonTypeEnum.Apple);
                base._baseButtonType = BaseButtonTypeEnum.Apple;
                break;
            default:
                SetValue(SigninButtonTypeProperty, SiginButtonTypeEnum.Generic);
                base._baseButtonType = BaseButtonTypeEnum.Signin;
                break;
        }
    }

    public SigninButton() : base(BaseButtonTypeEnum.Signin)
    {
    }
}
