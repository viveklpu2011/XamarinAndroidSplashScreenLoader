using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Lsjwzh.Widget.Materialloadingprogressbar {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='MaterialProgressDrawable']"
	[global::Android.Runtime.Register ("com/lsjwzh/widget/materialloadingprogressbar/MaterialProgressDrawable", DoNotGenerateAcw=true)]
	public partial class MaterialProgressDrawable : global::Android.Graphics.Drawables.Drawable, global::Android.Graphics.Drawables.IAnimatable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='MaterialProgressDrawable']/field[@name='DEFAULT']"
		[Register ("DEFAULT")]
		public const int Default = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='MaterialProgressDrawable']/field[@name='LARGE']"
		[Register ("LARGE")]
		public const int Large = (int) 0;
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/interface[@name='MaterialProgressDrawable.ProgressDrawableSize']"
		[Register ("com/lsjwzh/widget/materialloadingprogressbar/MaterialProgressDrawable$ProgressDrawableSize", "", "Com.Lsjwzh.Widget.Materialloadingprogressbar.MaterialProgressDrawable/IProgressDrawableSizeInvoker")]
		public partial interface IProgressDrawableSize : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("com/lsjwzh/widget/materialloadingprogressbar/MaterialProgressDrawable$ProgressDrawableSize", DoNotGenerateAcw=true)]
		internal class IProgressDrawableSizeInvoker : global::Java.Lang.Object, IProgressDrawableSize {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lsjwzh/widget/materialloadingprogressbar/MaterialProgressDrawable$ProgressDrawableSize", typeof (IProgressDrawableSizeInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IProgressDrawableSize GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IProgressDrawableSize> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.lsjwzh.widget.materialloadingprogressbar.MaterialProgressDrawable.ProgressDrawableSize"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IProgressDrawableSizeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_annotationType;
#pragma warning disable 0169
			static Delegate GetAnnotationTypeHandler ()
			{
				if (cb_annotationType == null)
					cb_annotationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AnnotationType);
				return cb_annotationType;
			}

			static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Lsjwzh.Widget.Materialloadingprogressbar.MaterialProgressDrawable.IProgressDrawableSize __this = global::Java.Lang.Object.GetObject<global::Com.Lsjwzh.Widget.Materialloadingprogressbar.MaterialProgressDrawable.IProgressDrawableSize> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
			}
#pragma warning restore 0169

			IntPtr id_annotationType;
			public unsafe global::Java.Lang.Class AnnotationType ()
			{
				if (id_annotationType == IntPtr.Zero)
					id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetEquals_Ljava_lang_Object_Handler ()
			{
				if (cb_equals_Ljava_lang_Object_ == null)
					cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
				return cb_equals_Ljava_lang_Object_;
			}

			static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				global::Com.Lsjwzh.Widget.Materialloadingprogressbar.MaterialProgressDrawable.IProgressDrawableSize __this = global::Java.Lang.Object.GetObject<global::Com.Lsjwzh.Widget.Materialloadingprogressbar.MaterialProgressDrawable.IProgressDrawableSize> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Equals (obj);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_equals_Ljava_lang_Object_;
			public unsafe global::System.Boolean Equals (global::Java.Lang.Object obj)
			{
				if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
					id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
				return __ret;
			}

			static Delegate cb_hashCode;
#pragma warning disable 0169
			static Delegate GetGetHashCodeHandler ()
			{
				if (cb_hashCode == null)
					cb_hashCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHashCode);
				return cb_hashCode;
			}

			static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Lsjwzh.Widget.Materialloadingprogressbar.MaterialProgressDrawable.IProgressDrawableSize __this = global::Java.Lang.Object.GetObject<global::Com.Lsjwzh.Widget.Materialloadingprogressbar.MaterialProgressDrawable.IProgressDrawableSize> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetHashCode ();
			}
#pragma warning restore 0169

			IntPtr id_hashCode;
			public unsafe global::System.Int32 GetHashCode ()
			{
				if (id_hashCode == IntPtr.Zero)
					id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
			}

			static Delegate cb_toString;
#pragma warning disable 0169
			static Delegate GetToStringHandler ()
			{
				if (cb_toString == null)
					cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
				return cb_toString;
			}

			static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Lsjwzh.Widget.Materialloadingprogressbar.MaterialProgressDrawable.IProgressDrawableSize __this = global::Java.Lang.Object.GetObject<global::Com.Lsjwzh.Widget.Materialloadingprogressbar.MaterialProgressDrawable.IProgressDrawableSize> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ToString ());
			}
#pragma warning restore 0169

			IntPtr id_toString;
			public unsafe global::System.String ToString ()
			{
				if (id_toString == IntPtr.Zero)
					id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			}

		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lsjwzh/widget/materialloadingprogressbar/MaterialProgressDrawable", typeof (MaterialProgressDrawable));
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

		protected MaterialProgressDrawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='MaterialProgressDrawable']/constructor[@name='MaterialProgressDrawable' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.view.View']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/view/View;)V", "")]
		public unsafe MaterialProgressDrawable (global::Android.Content.Context context, global::Android.Views.View animExcutor)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/view/View;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((animExcutor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) animExcutor).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_isRunning;
#pragma warning disable 0169
		static Delegate GetIsRunningHandler ()
		{
			if (cb_isRunning == null)
				cb_isRunning = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRunning);
			return cb_isRunning;
		}

		static bool n_IsRunning (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lsjwzh.Widget.Materialloadingprogressbar.MaterialProgressDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Lsjwzh.Widget.Materialloadingprogressbar.MaterialProgressDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRunning;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsRunning {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='MaterialProgressDrawable']/method[@name='isRunning' and count(parameter)=0]"
			[Register ("isRunning", "()Z", "GetIsRunningHandler")]
			get {
				const string __id = "isRunning.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getOpacity;
#pragma warning disable 0169
		static Delegate GetGetOpacityHandler ()
		{
			if (cb_getOpacity == null)
				cb_getOpacity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOpacity);
			return cb_getOpacity;
		}

		static int n_GetOpacity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lsjwzh.Widget.Materialloadingprogressbar.MaterialProgressDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Lsjwzh.Widget.Materialloadingprogressbar.MaterialProgressDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Opacity;
		}
#pragma warning restore 0169

		public override unsafe int Opacity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='MaterialProgressDrawable']/method[@name='getOpacity' and count(parameter)=0]"
			[Register ("getOpacity", "()I", "GetGetOpacityHandler")]
			get {
				const string __id = "getOpacity.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_draw_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetDraw_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_draw_Landroid_graphics_Canvas_ == null)
				cb_draw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Draw_Landroid_graphics_Canvas_);
			return cb_draw_Landroid_graphics_Canvas_;
		}

		static void n_Draw_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			global::Com.Lsjwzh.Widget.Materialloadingprogressbar.MaterialProgressDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Lsjwzh.Widget.Materialloadingprogressbar.MaterialProgressDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			__this.Draw (c);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='MaterialProgressDrawable']/method[@name='draw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("draw", "(Landroid/graphics/Canvas;)V", "GetDraw_Landroid_graphics_Canvas_Handler")]
		public override unsafe void Draw (global::Android.Graphics.Canvas c)
		{
			const string __id = "draw.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setAlpha_I;
#pragma warning disable 0169
		static Delegate GetSetAlpha_IHandler ()
		{
			if (cb_setAlpha_I == null)
				cb_setAlpha_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAlpha_I);
			return cb_setAlpha_I;
		}

		static void n_SetAlpha_I (IntPtr jnienv, IntPtr native__this, int alpha)
		{
			global::Com.Lsjwzh.Widget.Materialloadingprogressbar.MaterialProgressDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Lsjwzh.Widget.Materialloadingprogressbar.MaterialProgressDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAlpha (alpha);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='MaterialProgressDrawable']/method[@name='setAlpha' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAlpha", "(I)V", "GetSetAlpha_IHandler")]
		public override unsafe void SetAlpha (int alpha)
		{
			const string __id = "setAlpha.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (alpha);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setArrowScale_F;
#pragma warning disable 0169
		static Delegate GetSetArrowScale_FHandler ()
		{
			if (cb_setArrowScale_F == null)
				cb_setArrowScale_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetArrowScale_F);
			return cb_setArrowScale_F;
		}

		static void n_SetArrowScale_F (IntPtr jnienv, IntPtr native__this, float scale)
		{
			global::Com.Lsjwzh.Widget.Materialloadingprogressbar.MaterialProgressDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Lsjwzh.Widget.Materialloadingprogressbar.MaterialProgressDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetArrowScale (scale);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='MaterialProgressDrawable']/method[@name='setArrowScale' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setArrowScale", "(F)V", "GetSetArrowScale_FHandler")]
		public virtual unsafe void SetArrowScale (float scale)
		{
			const string __id = "setArrowScale.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (scale);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setBackgroundColor_I;
#pragma warning disable 0169
		static Delegate GetSetBackgroundColor_IHandler ()
		{
			if (cb_setBackgroundColor_I == null)
				cb_setBackgroundColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetBackgroundColor_I);
			return cb_setBackgroundColor_I;
		}

		static void n_SetBackgroundColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Lsjwzh.Widget.Materialloadingprogressbar.MaterialProgressDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Lsjwzh.Widget.Materialloadingprogressbar.MaterialProgressDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBackgroundColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='MaterialProgressDrawable']/method[@name='setBackgroundColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setBackgroundColor", "(I)V", "GetSetBackgroundColor_IHandler")]
		public virtual unsafe void SetBackgroundColor (int color)
		{
			const string __id = "setBackgroundColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setColorFilter_Landroid_graphics_ColorFilter_;
#pragma warning disable 0169
		static Delegate GetSetColorFilter_Landroid_graphics_ColorFilter_Handler ()
		{
			if (cb_setColorFilter_Landroid_graphics_ColorFilter_ == null)
				cb_setColorFilter_Landroid_graphics_ColorFilter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetColorFilter_Landroid_graphics_ColorFilter_);
			return cb_setColorFilter_Landroid_graphics_ColorFilter_;
		}

		static void n_SetColorFilter_Landroid_graphics_ColorFilter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_colorFilter)
		{
			global::Com.Lsjwzh.Widget.Materialloadingprogressbar.MaterialProgressDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Lsjwzh.Widget.Materialloadingprogressbar.MaterialProgressDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.ColorFilter colorFilter = global::Java.Lang.Object.GetObject<global::Android.Graphics.ColorFilter> (native_colorFilter, JniHandleOwnership.DoNotTransfer);
			__this.SetColorFilter (colorFilter);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='MaterialProgressDrawable']/method[@name='setColorFilter' and count(parameter)=1 and parameter[1][@type='android.graphics.ColorFilter']]"
		[Register ("setColorFilter", "(Landroid/graphics/ColorFilter;)V", "GetSetColorFilter_Landroid_graphics_ColorFilter_Handler")]
		public override unsafe void SetColorFilter (global::Android.Graphics.ColorFilter colorFilter)
		{
			const string __id = "setColorFilter.(Landroid/graphics/ColorFilter;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((colorFilter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) colorFilter).Handle);
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
			global::Com.Lsjwzh.Widget.Materialloadingprogressbar.MaterialProgressDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Lsjwzh.Widget.Materialloadingprogressbar.MaterialProgressDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] colors = (int[]) JNIEnv.GetArray (native_colors, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.SetColorSchemeColors (colors);
			if (colors != null)
				JNIEnv.CopyArray (colors, native_colors);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='MaterialProgressDrawable']/method[@name='setColorSchemeColors' and count(parameter)=1 and parameter[1][@type='int...']]"
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

		static Delegate cb_setProgressRotation_F;
#pragma warning disable 0169
		static Delegate GetSetProgressRotation_FHandler ()
		{
			if (cb_setProgressRotation_F == null)
				cb_setProgressRotation_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetProgressRotation_F);
			return cb_setProgressRotation_F;
		}

		static void n_SetProgressRotation_F (IntPtr jnienv, IntPtr native__this, float rotation)
		{
			global::Com.Lsjwzh.Widget.Materialloadingprogressbar.MaterialProgressDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Lsjwzh.Widget.Materialloadingprogressbar.MaterialProgressDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetProgressRotation (rotation);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='MaterialProgressDrawable']/method[@name='setProgressRotation' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setProgressRotation", "(F)V", "GetSetProgressRotation_FHandler")]
		public virtual unsafe void SetProgressRotation (float rotation)
		{
			const string __id = "setProgressRotation.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (rotation);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setSizeParameters_DDDDFF;
#pragma warning disable 0169
		static Delegate GetSetSizeParameters_DDDDFFHandler ()
		{
			if (cb_setSizeParameters_DDDDFF == null)
				cb_setSizeParameters_DDDDFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, double, double, double, float, float>) n_SetSizeParameters_DDDDFF);
			return cb_setSizeParameters_DDDDFF;
		}

		static void n_SetSizeParameters_DDDDFF (IntPtr jnienv, IntPtr native__this, double progressCircleWidth, double progressCircleHeight, double centerRadius, double strokeWidth, float arrowWidth, float arrowHeight)
		{
			global::Com.Lsjwzh.Widget.Materialloadingprogressbar.MaterialProgressDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Lsjwzh.Widget.Materialloadingprogressbar.MaterialProgressDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSizeParameters (progressCircleWidth, progressCircleHeight, centerRadius, strokeWidth, arrowWidth, arrowHeight);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='MaterialProgressDrawable']/method[@name='setSizeParameters' and count(parameter)=6 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='double'] and parameter[5][@type='float'] and parameter[6][@type='float']]"
		[Register ("setSizeParameters", "(DDDDFF)V", "GetSetSizeParameters_DDDDFFHandler")]
		public virtual unsafe void SetSizeParameters (double progressCircleWidth, double progressCircleHeight, double centerRadius, double strokeWidth, float arrowWidth, float arrowHeight)
		{
			const string __id = "setSizeParameters.(DDDDFF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (progressCircleWidth);
				__args [1] = new JniArgumentValue (progressCircleHeight);
				__args [2] = new JniArgumentValue (centerRadius);
				__args [3] = new JniArgumentValue (strokeWidth);
				__args [4] = new JniArgumentValue (arrowWidth);
				__args [5] = new JniArgumentValue (arrowHeight);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setStartEndTrim_FF;
#pragma warning disable 0169
		static Delegate GetSetStartEndTrim_FFHandler ()
		{
			if (cb_setStartEndTrim_FF == null)
				cb_setStartEndTrim_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_SetStartEndTrim_FF);
			return cb_setStartEndTrim_FF;
		}

		static void n_SetStartEndTrim_FF (IntPtr jnienv, IntPtr native__this, float startAngle, float endAngle)
		{
			global::Com.Lsjwzh.Widget.Materialloadingprogressbar.MaterialProgressDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Lsjwzh.Widget.Materialloadingprogressbar.MaterialProgressDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStartEndTrim (startAngle, endAngle);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='MaterialProgressDrawable']/method[@name='setStartEndTrim' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("setStartEndTrim", "(FF)V", "GetSetStartEndTrim_FFHandler")]
		public virtual unsafe void SetStartEndTrim (float startAngle, float endAngle)
		{
			const string __id = "setStartEndTrim.(FF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (startAngle);
				__args [1] = new JniArgumentValue (endAngle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_showArrow_Z;
#pragma warning disable 0169
		static Delegate GetShowArrow_ZHandler ()
		{
			if (cb_showArrow_Z == null)
				cb_showArrow_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_ShowArrow_Z);
			return cb_showArrow_Z;
		}

		static void n_ShowArrow_Z (IntPtr jnienv, IntPtr native__this, bool show)
		{
			global::Com.Lsjwzh.Widget.Materialloadingprogressbar.MaterialProgressDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Lsjwzh.Widget.Materialloadingprogressbar.MaterialProgressDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowArrow (show);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='MaterialProgressDrawable']/method[@name='showArrow' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("showArrow", "(Z)V", "GetShowArrow_ZHandler")]
		public virtual unsafe void ShowArrow (bool show)
		{
			const string __id = "showArrow.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (show);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_showArrowOnFirstStart_Z;
#pragma warning disable 0169
		static Delegate GetShowArrowOnFirstStart_ZHandler ()
		{
			if (cb_showArrowOnFirstStart_Z == null)
				cb_showArrowOnFirstStart_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_ShowArrowOnFirstStart_Z);
			return cb_showArrowOnFirstStart_Z;
		}

		static void n_ShowArrowOnFirstStart_Z (IntPtr jnienv, IntPtr native__this, bool showArrowOnFirstStart)
		{
			global::Com.Lsjwzh.Widget.Materialloadingprogressbar.MaterialProgressDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Lsjwzh.Widget.Materialloadingprogressbar.MaterialProgressDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowArrowOnFirstStart (showArrowOnFirstStart);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='MaterialProgressDrawable']/method[@name='showArrowOnFirstStart' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("showArrowOnFirstStart", "(Z)V", "GetShowArrowOnFirstStart_ZHandler")]
		public virtual unsafe void ShowArrowOnFirstStart (bool showArrowOnFirstStart)
		{
			const string __id = "showArrowOnFirstStart.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (showArrowOnFirstStart);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lsjwzh.Widget.Materialloadingprogressbar.MaterialProgressDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Lsjwzh.Widget.Materialloadingprogressbar.MaterialProgressDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='MaterialProgressDrawable']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual unsafe void Start ()
		{
			const string __id = "start.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lsjwzh.Widget.Materialloadingprogressbar.MaterialProgressDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Lsjwzh.Widget.Materialloadingprogressbar.MaterialProgressDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='MaterialProgressDrawable']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			const string __id = "stop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_updateSizes_I;
#pragma warning disable 0169
		static Delegate GetUpdateSizes_IHandler ()
		{
			if (cb_updateSizes_I == null)
				cb_updateSizes_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_UpdateSizes_I);
			return cb_updateSizes_I;
		}

		static void n_UpdateSizes_I (IntPtr jnienv, IntPtr native__this, int size)
		{
			global::Com.Lsjwzh.Widget.Materialloadingprogressbar.MaterialProgressDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Lsjwzh.Widget.Materialloadingprogressbar.MaterialProgressDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateSizes (size);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lsjwzh.widget.materialloadingprogressbar']/class[@name='MaterialProgressDrawable']/method[@name='updateSizes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("updateSizes", "(I)V", "GetUpdateSizes_IHandler")]
		public virtual unsafe void UpdateSizes ([global::Android.Runtime.IntDef (Type = "Com.Lsjwzh.Widget.Materialloadingprogressbar.MaterialProgressDrawable", Fields = new string [] {"Large", "Default"})]int size)
		{
			const string __id = "updateSizes.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (size);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
