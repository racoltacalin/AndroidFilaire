//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class proto_hdle_t : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal proto_hdle_t(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(proto_hdle_t obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~proto_hdle_t() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          protocommPINVOKE.delete_proto_hdle_t(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_f_p_void_enum_proto_Command_p_union_proto_frame_data__int priv_callback {
    set {
      protocommPINVOKE.proto_hdle_t_priv_callback_set(swigCPtr, SWIGTYPE_p_f_p_void_enum_proto_Command_p_union_proto_frame_data__int.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = protocommPINVOKE.proto_hdle_t_priv_callback_get(swigCPtr);
      SWIGTYPE_p_f_p_void_enum_proto_Command_p_union_proto_frame_data__int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_void_enum_proto_Command_p_union_proto_frame_data__int(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_void priv_userdata {
    set {
      protocommPINVOKE.proto_hdle_t_priv_userdata_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = protocommPINVOKE.proto_hdle_t_priv_userdata_get(swigCPtr);
      SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
      return ret;
    } 
  }

  public proto_Frame_t priv_frame {
    set {
      protocommPINVOKE.proto_hdle_t_priv_frame_set(swigCPtr, proto_Frame_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = protocommPINVOKE.proto_hdle_t_priv_frame_get(swigCPtr);
      proto_Frame_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new proto_Frame_t(cPtr, false);
      return ret;
    } 
  }

  public byte priv_nbBytes {
    set {
      protocommPINVOKE.proto_hdle_t_priv_nbBytes_set(swigCPtr, value);
    } 
    get {
      byte ret = protocommPINVOKE.proto_hdle_t_priv_nbBytes_get(swigCPtr);
      return ret;
    } 
  }

  public proto_IfaceIODevice_t priv_iodevice {
    set {
      protocommPINVOKE.proto_hdle_t_priv_iodevice_set(swigCPtr, proto_IfaceIODevice_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = protocommPINVOKE.proto_hdle_t_priv_iodevice_get(swigCPtr);
      proto_IfaceIODevice_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new proto_IfaceIODevice_t(cPtr, false);
      return ret;
    } 
  }

  public proto_hdle_t() : this(protocommPINVOKE.new_proto_hdle_t(), true) {
  }

}
