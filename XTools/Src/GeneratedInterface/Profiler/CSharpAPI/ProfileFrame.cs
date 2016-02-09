/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace XTools {

public class ProfileFrame : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ProfileFrame(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ProfileFrame obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ProfileFrame() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          XToolsProfilerPINVOKE.delete_ProfileFrame(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public ProfileFrame() : this(XToolsProfilerPINVOKE.new_ProfileFrame(), true) {
  }

  public int GetThreadCount() {
    int ret = XToolsProfilerPINVOKE.ProfileFrame_GetThreadCount(swigCPtr);
    return ret;
  }

  public ProfileThread GetThread(int threadIndex) {
    global::System.IntPtr cPtr = XToolsProfilerPINVOKE.ProfileFrame_GetThread(swigCPtr, threadIndex);
    ProfileThread ret = (cPtr == global::System.IntPtr.Zero) ? null : new ProfileThread(cPtr, true);
    return ret; 
  }

  public int GetLogMessageCount() {
    int ret = XToolsProfilerPINVOKE.ProfileFrame_GetLogMessageCount(swigCPtr);
    return ret;
  }

  public LogMessage GetLogMessage(int messageIndex) {
    global::System.IntPtr cPtr = XToolsProfilerPINVOKE.ProfileFrame_GetLogMessage(swigCPtr, messageIndex);
    LogMessage ret = (cPtr == global::System.IntPtr.Zero) ? null : new LogMessage(cPtr, true);
    return ret; 
  }

  public void AddThread(ProfileThread newThread) {
    XToolsProfilerPINVOKE.ProfileFrame_AddThread(swigCPtr, ProfileThread.getCPtr(newThread));
  }

  public void AddMessage(LogMessage newMessage) {
    XToolsProfilerPINVOKE.ProfileFrame_AddMessage(swigCPtr, LogMessage.getCPtr(newMessage));
  }

}

}