// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Settings/ClientPerformanceSettings.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Settings {

  /// <summary>Holder for reflection information generated from POGOProtos/Settings/ClientPerformanceSettings.proto</summary>
  public static partial class ClientPerformanceSettingsReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Settings/ClientPerformanceSettings.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientPerformanceSettingsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNQT0dPUHJvdG9zL1NldHRpbmdzL0NsaWVudFBlcmZvcm1hbmNlU2V0dGlu",
            "Z3MucHJvdG8SE1BPR09Qcm90b3MuU2V0dGluZ3MiZwoZQ2xpZW50UGVyZm9y",
            "bWFuY2VTZXR0aW5ncxIhChllbmFibGVfbG9jYWxfZGlza19jYWNoaW5nGAEg",
            "ASgIEicKH21heF9udW1iZXJfbG9jYWxfYmF0dGxlX3BhcnRpZXMYAiABKAVi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Settings.ClientPerformanceSettings), global::POGOProtos.Settings.ClientPerformanceSettings.Parser, new[]{ "EnableLocalDiskCaching", "MaxNumberLocalBattleParties" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientPerformanceSettings : pb::IMessage<ClientPerformanceSettings> {
    private static readonly pb::MessageParser<ClientPerformanceSettings> _parser = new pb::MessageParser<ClientPerformanceSettings>(() => new ClientPerformanceSettings());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientPerformanceSettings> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Settings.ClientPerformanceSettingsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientPerformanceSettings() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientPerformanceSettings(ClientPerformanceSettings other) : this() {
      enableLocalDiskCaching_ = other.enableLocalDiskCaching_;
      maxNumberLocalBattleParties_ = other.maxNumberLocalBattleParties_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientPerformanceSettings Clone() {
      return new ClientPerformanceSettings(this);
    }

    /// <summary>Field number for the "enable_local_disk_caching" field.</summary>
    public const int EnableLocalDiskCachingFieldNumber = 1;
    private bool enableLocalDiskCaching_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool EnableLocalDiskCaching {
      get { return enableLocalDiskCaching_; }
      set {
        enableLocalDiskCaching_ = value;
      }
    }

    /// <summary>Field number for the "max_number_local_battle_parties" field.</summary>
    public const int MaxNumberLocalBattlePartiesFieldNumber = 2;
    private int maxNumberLocalBattleParties_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MaxNumberLocalBattleParties {
      get { return maxNumberLocalBattleParties_; }
      set {
        maxNumberLocalBattleParties_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientPerformanceSettings);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientPerformanceSettings other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EnableLocalDiskCaching != other.EnableLocalDiskCaching) return false;
      if (MaxNumberLocalBattleParties != other.MaxNumberLocalBattleParties) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (EnableLocalDiskCaching != false) hash ^= EnableLocalDiskCaching.GetHashCode();
      if (MaxNumberLocalBattleParties != 0) hash ^= MaxNumberLocalBattleParties.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (EnableLocalDiskCaching != false) {
        output.WriteRawTag(8);
        output.WriteBool(EnableLocalDiskCaching);
      }
      if (MaxNumberLocalBattleParties != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(MaxNumberLocalBattleParties);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (EnableLocalDiskCaching != false) {
        size += 1 + 1;
      }
      if (MaxNumberLocalBattleParties != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxNumberLocalBattleParties);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientPerformanceSettings other) {
      if (other == null) {
        return;
      }
      if (other.EnableLocalDiskCaching != false) {
        EnableLocalDiskCaching = other.EnableLocalDiskCaching;
      }
      if (other.MaxNumberLocalBattleParties != 0) {
        MaxNumberLocalBattleParties = other.MaxNumberLocalBattleParties;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            EnableLocalDiskCaching = input.ReadBool();
            break;
          }
          case 16: {
            MaxNumberLocalBattleParties = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
