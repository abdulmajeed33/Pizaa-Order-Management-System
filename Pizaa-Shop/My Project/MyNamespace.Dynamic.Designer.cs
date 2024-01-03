using System;
using System.ComponentModel;
using System.Diagnostics;

namespace Pizaa_Shop.My
{
    internal static partial class MyProject
    {
        internal partial class MyForms
        {

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Billing m_Billing;

            public Billing Billing
            {
                [DebuggerHidden]
                get
                {
                    m_Billing = Create__Instance__(m_Billing);
                    return m_Billing;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Billing))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Billing);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Login m_Login;

            public Login Login
            {
                [DebuggerHidden]
                get
                {
                    m_Login = Create__Instance__(m_Login);
                    return m_Login;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Login))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Login);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Settings m_Settings;

            public Settings Settings
            {
                [DebuggerHidden]
                get
                {
                    m_Settings = Create__Instance__(m_Settings);
                    return m_Settings;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Settings))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Settings);
                }
            }

        }


    }
}