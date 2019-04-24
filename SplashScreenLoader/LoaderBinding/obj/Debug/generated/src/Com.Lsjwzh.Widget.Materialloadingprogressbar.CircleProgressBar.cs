using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Lsjwzh.Widget.Materialloadingprogressbar {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='CircleProgressBar']"
	[global::Android.Runtime.Register ("com/lsjwzh/widget/materialloadingprogressbar/CircleProgressBar", DoNotGenerateAcw=true)]
	public partial class CircleProgressBar : global::Android.Widget.ImageView {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='CircleProgressBar']/field[@name='DEFAULT_TEXT_SIZE']"
		[Register ("DEFAULT_TEXT_SIZE")]
		public const int DefaultTextSize = (int) 9;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lsjwzh/widget/materialloadingprogressbar/CircleProgressBar", typeof (CircleProgressBar));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected CircleProgressBar (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='CircleProgressBar']/constructor[@name='CircleProgressBar' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe CircleProgressBar (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='CircleProgressBar']/constructor[@name='CircleProgressBar' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe CircleProgressBar (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='CircleProgressBar']/constructor[@name='CircleProgressBar' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe CircleProgressBar (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				__args [2] = new JniArgumentValue (defStyleAttr);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getMax;
#pragma warning disable 0169
		static Delegate GetGetMaxHandler ()
		{
			if (cb_getMax == null)
				cb_getMax = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMax);
			return cb_getMax;
		}

		static int n_GetMax (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lsjwzh.Widget.Materialloadingprogressbar.CircleProgressBar __this = global::Java.Lang.Object.GetObject<global::Com.Lsjwzh.Widget.Materialloadingprogressbar.CircleProgressBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Max;
		}
#pragma warning restore 0169

		static Delegate cb_setMax_I;
#pragma warning disable 0169
		static Delegate GetSetMax_IHandler ()
		{
			if (cb_setMax_I == null)
				cb_setMax_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMax_I);
			return cb_setMax_I;
		}

		static void n_SetMax_I (IntPtr jnienv, IntPtr native__this, int max)
		{
			global::Com.Lsjwzh.Widget.Materialloadingprogressbar.CircleProgressBar __this = global::Java.Lang.Object.GetObject<global::Com.Lsjwzh.Widget.Materialloadingprogressbar.CircleProgressBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Max = max;
		}
#pragma warning restore 0169

		public virtual unsafe int Max {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='CircleProgressBar']/method[@name='getMax' and count(parameter)=0]"
			[Register ("getMax", "()I", "GetGetMaxHandler")]
			get {
				const string __id = "getMax.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='CircleProgressBar']/method[@name='setMax' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMax", "(I)V", "GetSetMax_IHandler")]
			set {
				const string __id = "setMax.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getProgress;
#pragma warning disable 0169
		static Delegate GetGetProgressHandler ()
		{
			if (cb_getProgress == null)
				cb_getProgress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetProgress);
			return cb_getProgress;
		}

		static int n_GetProgress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lsjwzh.Widget.Materialloadingprogressbar.CircleProgressBar __this = global::Java.Lang.Object.GetObject<global::Com.Lsjwzh.Widget.Materialloadingprogressbar.CircleProgressBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Progress;
		}
#pragma warning restore 0169

		static Delegate cb_setProgress_I;
#pragma warning disable 0169
		static Delegate GetSetProgress_IHandler ()
		{
			if (cb_setProgress_I == null)
				cb_setProgress_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetProgress_I);
			return cb_setProgress_I;
		}

		static void n_SetProgress_I (IntPtr jnienv, IntPtr native__this, int progress)
		{
			global::Com.Lsjwzh.Widget.Materialloadingprogressbar.CircleProgressBar __this = global::Java.Lang.Object.GetObject<global::Com.Lsjwzh.Widget.Materialloadingprogressbar.CircleProgressBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Progress = progress;
		}
#pragma warning restore 0169

		public virtual unsafe int Progress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='CircleProgressBar']/method[@name='getProgress' and count(parameter)=0]"
			[Register ("getProgress", "()I", "GetGetProgressHandler")]
			get {
				const string __id = "getProgress.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='CircleProgressBar']/method[@name='setProgress' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setProgress", "(I)V", "GetSetProgress_IHandler")]
			set {
				const string __id = "setProgress.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isShowArrow;
#pragma warning disable 0169
		static Delegate GetIsShowArrowHandler ()
		{
			if (cb_isShowArrow == null)
				cb_isShowArrow = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsShowArrow);
			return cb_isShowArrow;
		}

		static bool n_IsShowArrow (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lsjwzh.Widget.Materialloadingprogressbar.CircleProgressBar __this = global::Java.Lang.Object.GetObject<global::Com.Lsjwzh.Widget.Materialloadingprogressbar.CircleProgressBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShowArrow;
		}
#pragma warning restore 0169

		static Delegate cb_setShowArrow_Z;
#pragma warning disable 0169
		static Delegate GetSetShowArrow_ZHandler ()
		{
			if (cb_setShowArrow_Z == null)
				cb_setShowArrow_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShowArrow_Z);
			return cb_setShowArrow_Z;
		}

		static void n_SetShowArrow_Z (IntPtr jnienv, IntPtr native__this, bool showArrow)
		{
			global::Com.Lsjwzh.Widget.Materialloadingprogressbar.CircleProgressBar __this = global::Java.Lang.Object.GetObject<global::Com.Lsjwzh.Widget.Materialloadingprogressbar.CircleProgressBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowArrow = showArrow;
		}
#pragma warning restore 0169

		public virtual unsafe bool ShowArrow {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='CircleProgressBar']/method[@name='isShowArrow' and count(parameter)=0]"
			[Register ("isShowArrow", "()Z", "GetIsShowArrowHandler")]
			get {
				const string __id = "isShowArrow.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='CircleProgressBar']/method[@name='setShowArrow' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setShowArrow", "(Z)V", "GetSetShowArrow_ZHandler")]
			set {
				const string __id = "setShowArrow.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isShowProgressText;
#pragma warning disable 0169
		static Delegate GetIsShowProgressTextHandler ()
		{
			if (cb_isShowProgressText == null)
				cb_isShowProgressText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsShowProgressText);
			return cb_isShowProgressText;
		}

		static bool n_IsShowProgressText (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lsjwzh.Widget.Materialloadingprogressbar.CircleProgressBar __this = global::Java.Lang.Object.GetObject<global::Com.Lsjwzh.Widget.Materialloadingprogressbar.CircleProgressBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShowProgressText;
		}
#pragma warning restore 0169

		static Delegate cb_setShowProgressText_Z;
#pragma warning disable 0169
		static Delegate GetSetShowProgressText_ZHandler ()
		{
			if (cb_setShowProgressText_Z == null)
				cb_setShowProgressText_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShowProgressText_Z);
			return cb_setShowProgressText_Z;
		}

		static void n_SetShowProgressText_Z (IntPtr jnienv, IntPtr native__this, bool mIfDrawText)
		{
			global::Com.Lsjwzh.Widget.Materialloadingprogressbar.CircleProgressBar __this = global::Java.Lang.Object.GetObject<global::Com.Lsjwzh.Widget.Materialloadingprogressbar.CircleProgressBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowProgressText = mIfDrawText;
		}
#pragma warning restore 0169

		public virtual unsafe bool ShowProgressText {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='CircleProgressBar']/method[@name='isShowProgressText' and count(parameter)=0]"
			[Register ("isShowProgressText", "()Z", "GetIsShowProgressTextHandler")]
			get {
				const string __id = "isShowProgressText.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='CircleProgressBar']/method[@name='setShowProgressText' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setShowProgressText", "(Z)V", "GetSetShowProgressText_ZHandler")]
			set {
				const string __id = "setShowProgressText.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_circleBackgroundEnabled;
#pragma warning disable 0169
		static Delegate GetCircleBackgroundEnabledHandler ()
		{
			if (cb_circleBackgroundEnabled == null)
				cb_circleBackgroundEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CircleBackgroundEnabled);
			return cb_circleBackgroundEnabled;
		}

		static bool n_CircleBackgroundEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lsjwzh.Widget.Materialloadingprogressbar.CircleProgressBar __this = global::Java.Lang.Object.GetObject<global::Com.Lsjwzh.Widget.Materialloadingprogressbar.CircleProgressBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CircleBackgroundEnabled ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='CircleProgressBar']/method[@name='circleBackgroundEnabled' and count(parameter)=0]"
		[Register ("circleBackgroundEnabled", "()Z", "GetCircleBackgroundEnabledHandler")]
		public virtual unsafe bool CircleBackgroundEnabled ()
		{
			const string __id = "circleBackgroundEnabled.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_onAnimationEnd;
#pragma warning disable 0169
		static Delegate GetOnAnimationEndHandler ()
		{
			if (cb_onAnimationEnd == null)
				cb_onAnimationEnd = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnAnimationEnd);
			return cb_onAnimationEnd;
		}

		static void n_OnAnimationEnd (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lsjwzh.Widget.Materialloadingprogressbar.CircleProgressBar __this = global::Java.Lang.Object.GetObject<global::Com.Lsjwzh.Widget.Materialloadingprogressbar.CircleProgressBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAnimationEnd ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='CircleProgressBar']/method[@name='onAnimationEnd' and count(parameter)=0]"
		[Register ("onAnimationEnd", "()V", "GetOnAnimationEndHandler")]
		public virtual unsafe void OnAnimationEnd ()
		{
			const string __id = "onAnimationEnd.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onAnimationStart;
#pragma warning disable 0169
		static Delegate GetOnAnimationStartHandler ()
		{
			if (cb_onAnimationStart == null)
				cb_onAnimationStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnAnimationStart);
			return cb_onAnimationStart;
		}

		static void n_OnAnimationStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lsjwzh.Widget.Materialloadingprogressbar.CircleProgressBar __this = global::Java.Lang.Object.GetObject<global::Com.Lsjwzh.Widget.Materialloadingprogressbar.CircleProgressBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAnimationStart ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='CircleProgressBar']/method[@name='onAnimationStart' and count(parameter)=0]"
		[Register ("onAnimationStart", "()V", "GetOnAnimationStartHandler")]
		public virtual unsafe void OnAnimationStart ()
		{
			const string __id = "onAnimationStart.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setAnimationListener_Landroid_view_animation_Animation_AnimationListener_;
#pragma warning disable 0169
		static Delegate GetSetAnimationListener_Landroid_view_animation_Animation_AnimationListener_Handler ()
		{
			if (cb_setAnimationListener_Landroid_view_animation_Animation_AnimationListener_ == null)
				cb_setAnimationListener_Landroid_view_animation_Animation_AnimationListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAnimationListener_Landroid_view_animation_Animation_AnimationListener_);
			return cb_setAnimationListener_Landroid_view_animation_Animation_AnimationListener_;
		}

		static void n_SetAnimationListener_Landroid_view_animation_Animation_AnimationListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Lsjwzh.Widget.Materialloadingprogressbar.CircleProgressBar __this = global::Java.Lang.Object.GetObject<global::Com.Lsjwzh.Widget.Materialloadingprogressbar.CircleProgressBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.Animations.Animation.IAnimationListener listener = (global::Android.Views.Animations.Animation.IAnimationListener)global::Java.Lang.Object.GetObject<global::Android.Views.Animations.Animation.IAnimationListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetAnimationListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='CircleProgressBar']/method[@name='setAnimationListener' and count(parameter)=1 and parameter[1][@type='android.view.animation.Animation.AnimationListener']]"
		[Register ("setAnimationListener", "(Landroid/view/animation/Animation$AnimationListener;)V", "GetSetAnimationListener_Landroid_view_animation_Animation_AnimationListener_Handler")]
		public virtual unsafe void SetAnimationListener (global::Android.Views.Animations.Animation.IAnimationListener listener)
		{
			const string __id = "setAnimationListener.(Landroid/view/animation/Animation$AnimationListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setCircleBackgroundEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetCircleBackgroundEnabled_ZHandler ()
		{
			if (cb_setCircleBackgroundEnabled_Z == null)
				cb_setCircleBackgroundEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetCircleBackgroundEnabled_Z);
			return cb_setCircleBackgroundEnabled_Z;
		}

		static void n_SetCircleBackgroundEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enableCircleBackground)
		{
			global::Com.Lsjwzh.Widget.Materialloadingprogressbar.CircleProgressBar __this = global::Java.Lang.Object.GetObject<global::Com.Lsjwzh.Widget.Materialloadingprogressbar.CircleProgressBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCircleBackgroundEnabled (enableCircleBackground);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='CircleProgressBar']/method[@name='setCircleBackgroundEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setCircleBackgroundEnabled", "(Z)V", "GetSetCircleBackgroundEnabled_ZHandler")]
		public virtual unsafe void SetCircleBackgroundEnabled (bool enableCircleBackground)
		{
			const string __id = "setCircleBackgroundEnabled.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enableCircleBackground);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setColorSchemeColors_arrayI;
#pragma warning disable 0169
		static Delegate GetSetColorSchemeColors_arrayIHandler ()
		{
			if (cb_setColorSchemeColors_arrayI == null)
				cb_setColorSchemeColors_arrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetColorSchemeColors_arrayI);
			return cb_setColorSchemeColors_arrayI;
		}

		static void n_SetColorSchemeColors_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_colors)
		{
			global::Com.Lsjwzh.Widget.Materialloadingprogressbar.CircleProgressBar __this = global::Java.Lang.Object.GetObject<global::Com.Lsjwzh.Widget.Materialloadingprogressbar.CircleProgressBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] colors = (int[]) JNIEnv.GetArray (native_colors, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.SetColorSchemeColors (colors);
			if (colors != null)
				JNIEnv.CopyArray (colors, native_colors);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='CircleProgressBar']/method[@name='setColorSchemeColors' and count(parameter)=1 and parameter[1][@type='int...']]"
		[Register ("setColorSchemeColors", "([I)V", "GetSetColorSchemeColors_arrayIHandler")]
		public virtual unsafe void SetColorSchemeColors (params int[] colors)
		{
			const string __id = "setColorSchemeColors.([I)V";
			IntPtr native_colors = JNIEnv.NewArray (colors);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_colors);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (colors != null) {
					JNIEnv.CopyArray (native_colors, colors);
					JNIEnv.DeleteLocalRef (native_colors);
				}
			}
		}

		static Delegate cb_setColorSchemeResources_arrayI;
#pragma warning disable 0169
		static Delegate GetSetColorSchemeResources_arrayIHandler ()
		{
			if (cb_setColorSchemeResources_arrayI == null)
				cb_setColorSchemeResources_arrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetColorSchemeResources_arrayI);
			return cb_setColorSchemeResources_arrayI;
		}

		static void n_SetColorSchemeResources_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_colorResIds)
		{
			global::Com.Lsjwzh.Widget.Materialloadingprogressbar.CircleProgressBar __this = global::Java.Lang.Object.GetObject<global::Com.Lsjwzh.Widget.Materialloadingprogressbar.CircleProgressBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] colorResIds = (int[]) JNIEnv.GetArray (native_colorResIds, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.SetColorSchemeResources (colorResIds);
			if (colorResIds != null)
				JNIEnv.CopyArray (colorResIds, native_colorResIds);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='CircleProgressBar']/method[@name='setColorSchemeResources' and count(parameter)=1 and parameter[1][@type='int...']]"
		[Register ("setColorSchemeResources", "([I)V", "GetSetColorSchemeResources_arrayIHandler")]
		public virtual unsafe void SetColorSchemeResources (params int[] colorResIds)
		{
			const string __id = "setColorSchemeResources.([I)V";
			IntPtr native_colorResIds = JNIEnv.NewArray (colorResIds);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_colorResIds);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (colorResIds != null) {
					JNIEnv.CopyArray (native_colorResIds, colorResIds);
					JNIEnv.DeleteLocalRef (native_colorResIds);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='CircleProgressBar']/method[@name='setImageDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setImageDrawable", "(Landroid/graphics/drawable/Drawable;)V", "")]
		public override sealed unsafe void SetImageDrawable (global::Android.Graphics.Drawables.Drawable drawable)
		{
			const string __id = "setImageDrawable.(Landroid/graphics/drawable/Drawable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='CircleProgressBar']/method[@name='setImageResource' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setImageResource", "(I)V", "")]
		public override sealed unsafe void SetImageResource (int resId)
		{
			const string __id = "setImageResource.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (resId);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='CircleProgressBar']/method[@name='setImageURI' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("setImageURI", "(Landroid/net/Uri;)V", "")]
		public override sealed unsafe void SetImageURI (global::Android.Net.Uri uri)
		{
			const string __id = "setImageURI.(Landroid/net/Uri;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
