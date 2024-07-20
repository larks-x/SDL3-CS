/*
  <auto-generated/>
  C# bindings for Simple DirectMedia Layer.
  Original copyright notice of input files:

  Simple DirectMedia Layer
  Copyright (C) 1997-2024 Sam Lantinga <slouken@libsdl.org>

  This software is provided 'as-is', without any express or implied
  warranty.  In no event will the authors be held liable for any damages
  arising from the use of this software.

  Permission is granted to anyone to use this software for any purpose,
  including commercial applications, and to alter it and redistribute it
  freely, subject to the following restrictions:

  1. The origin of this software must not be misrepresented; you must not
     claim that you wrote the original software. If you use this software
     in a product, an acknowledgment in the product documentation would be
     appreciated but is not required.
  2. Altered source versions must be plainly marked as such, and must not be
     misrepresented as being the original software.
  3. This notice may not be removed or altered from any source distribution.
*/

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SDL
{
    public partial struct SDL_Joystick
    {
    }

    public enum SDL_JoystickType
    {
        SDL_JOYSTICK_TYPE_UNKNOWN,
        SDL_JOYSTICK_TYPE_GAMEPAD,
        SDL_JOYSTICK_TYPE_WHEEL,
        SDL_JOYSTICK_TYPE_ARCADE_STICK,
        SDL_JOYSTICK_TYPE_FLIGHT_STICK,
        SDL_JOYSTICK_TYPE_DANCE_PAD,
        SDL_JOYSTICK_TYPE_GUITAR,
        SDL_JOYSTICK_TYPE_DRUM_KIT,
        SDL_JOYSTICK_TYPE_ARCADE_PAD,
        SDL_JOYSTICK_TYPE_THROTTLE,
    }

    public enum SDL_JoystickConnectionState
    {
        SDL_JOYSTICK_CONNECTION_INVALID = -1,
        SDL_JOYSTICK_CONNECTION_UNKNOWN,
        SDL_JOYSTICK_CONNECTION_WIRED,
        SDL_JOYSTICK_CONNECTION_WIRELESS,
    }

    public partial struct SDL_VirtualJoystickTouchpadDesc
    {
        [NativeTypeName("Uint16")]
        public ushort nfingers;

        [NativeTypeName("Uint16[3]")]
        public _padding_e__FixedBuffer padding;

        [InlineArray(3)]
        public partial struct _padding_e__FixedBuffer
        {
            public ushort e0;
        }
    }

    public partial struct SDL_VirtualJoystickSensorDesc
    {
        public SDL_SensorType type;

        public float rate;
    }

    public unsafe partial struct SDL_VirtualJoystickDesc
    {
        [NativeTypeName("Uint16")]
        public ushort type;

        [NativeTypeName("Uint16")]
        public ushort padding;

        [NativeTypeName("Uint16")]
        public ushort vendor_id;

        [NativeTypeName("Uint16")]
        public ushort product_id;

        [NativeTypeName("Uint16")]
        public ushort naxes;

        [NativeTypeName("Uint16")]
        public ushort nbuttons;

        [NativeTypeName("Uint16")]
        public ushort nballs;

        [NativeTypeName("Uint16")]
        public ushort nhats;

        [NativeTypeName("Uint16")]
        public ushort ntouchpads;

        [NativeTypeName("Uint16")]
        public ushort nsensors;

        [NativeTypeName("Uint16[2]")]
        public _padding2_e__FixedBuffer padding2;

        [NativeTypeName("Uint32")]
        public uint button_mask;

        [NativeTypeName("Uint32")]
        public uint axis_mask;

        [NativeTypeName("const char *")]
        public byte* name;

        [NativeTypeName("const SDL_VirtualJoystickTouchpadDesc *")]
        public SDL_VirtualJoystickTouchpadDesc* touchpads;

        [NativeTypeName("const SDL_VirtualJoystickSensorDesc *")]
        public SDL_VirtualJoystickSensorDesc* sensors;

        [NativeTypeName("void*")]
        public IntPtr userdata;

        [NativeTypeName("void (*)(void *)")]
        public delegate* unmanaged[Cdecl]<IntPtr, void> Update;

        [NativeTypeName("void (*)(void *, int)")]
        public delegate* unmanaged[Cdecl]<IntPtr, int, void> SetPlayerIndex;

        [NativeTypeName("int (*)(void *, Uint16, Uint16)")]
        public delegate* unmanaged[Cdecl]<IntPtr, ushort, ushort, int> Rumble;

        [NativeTypeName("int (*)(void *, Uint16, Uint16)")]
        public delegate* unmanaged[Cdecl]<IntPtr, ushort, ushort, int> RumbleTriggers;

        [NativeTypeName("int (*)(void *, Uint8, Uint8, Uint8)")]
        public delegate* unmanaged[Cdecl]<IntPtr, byte, byte, byte, int> SetLED;

        [NativeTypeName("int (*)(void *, const void *, int)")]
        public delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int> SendEffect;

        [NativeTypeName("int (*)(void *, SDL_bool)")]
        public delegate* unmanaged[Cdecl]<IntPtr, SDL_bool, int> SetSensorsEnabled;

        [InlineArray(2)]
        public partial struct _padding2_e__FixedBuffer
        {
            public ushort e0;
        }
    }

    public static unsafe partial class SDL3
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_LockJoysticks();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_UnlockJoysticks();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_HasJoystick();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const SDL_JoystickID *")]
        public static extern SDL_JoystickID* SDL_GetJoysticks(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickNameForID", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* Unsafe_SDL_GetJoystickNameForID(SDL_JoystickID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickPathForID", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* Unsafe_SDL_GetJoystickPathForID(SDL_JoystickID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetJoystickPlayerIndexForID(SDL_JoystickID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GUID SDL_GetJoystickGUIDForID(SDL_JoystickID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort SDL_GetJoystickVendorForID(SDL_JoystickID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort SDL_GetJoystickProductForID(SDL_JoystickID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort SDL_GetJoystickProductVersionForID(SDL_JoystickID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_JoystickType SDL_GetJoystickTypeForID(SDL_JoystickID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Joystick* SDL_OpenJoystick(SDL_JoystickID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Joystick* SDL_GetJoystickFromID(SDL_JoystickID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Joystick* SDL_GetJoystickFromPlayerIndex(int player_index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_JoystickID SDL_AttachVirtualJoystick([NativeTypeName("const SDL_VirtualJoystickDesc *")] SDL_VirtualJoystickDesc* desc);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_DetachVirtualJoystick(SDL_JoystickID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_IsJoystickVirtual(SDL_JoystickID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetJoystickVirtualAxis(SDL_Joystick* joystick, int axis, [NativeTypeName("Sint16")] short value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetJoystickVirtualBall(SDL_Joystick* joystick, int ball, [NativeTypeName("Sint16")] short xrel, [NativeTypeName("Sint16")] short yrel);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetJoystickVirtualButton(SDL_Joystick* joystick, int button, [NativeTypeName("Uint8")] byte value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetJoystickVirtualHat(SDL_Joystick* joystick, int hat, [NativeTypeName("Uint8")] byte value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetJoystickVirtualTouchpad(SDL_Joystick* joystick, int touchpad, int finger, [NativeTypeName("Uint8")] byte state, float x, float y, float pressure);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SendJoystickVirtualSensorData(SDL_Joystick* joystick, SDL_SensorType type, [NativeTypeName("Uint64")] ulong sensor_timestamp, [NativeTypeName("const float *")] float* data, int num_values);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_PropertiesID SDL_GetJoystickProperties(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickName", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* Unsafe_SDL_GetJoystickName(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickPath", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* Unsafe_SDL_GetJoystickPath(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetJoystickPlayerIndex(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetJoystickPlayerIndex(SDL_Joystick* joystick, int player_index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GUID SDL_GetJoystickGUID(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort SDL_GetJoystickVendor(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort SDL_GetJoystickProduct(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort SDL_GetJoystickProductVersion(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort SDL_GetJoystickFirmwareVersion(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickSerial", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* Unsafe_SDL_GetJoystickSerial(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_JoystickType SDL_GetJoystickType(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_GetJoystickGUIDInfo(SDL_GUID guid, [NativeTypeName("Uint16 *")] ushort* vendor, [NativeTypeName("Uint16 *")] ushort* product, [NativeTypeName("Uint16 *")] ushort* version, [NativeTypeName("Uint16 *")] ushort* crc16);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_JoystickConnected(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_JoystickID SDL_GetJoystickID(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetNumJoystickAxes(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetNumJoystickBalls(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetNumJoystickHats(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetNumJoystickButtons(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetJoystickEventsEnabled(SDL_bool enabled);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_JoystickEventsEnabled();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_UpdateJoysticks();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Sint16")]
        public static extern short SDL_GetJoystickAxis(SDL_Joystick* joystick, int axis);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_GetJoystickAxisInitialState(SDL_Joystick* joystick, int axis, [NativeTypeName("Sint16 *")] short* state);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetJoystickBall(SDL_Joystick* joystick, int ball, int* dx, int* dy);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint8")]
        public static extern byte SDL_GetJoystickHat(SDL_Joystick* joystick, int hat);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint8")]
        public static extern byte SDL_GetJoystickButton(SDL_Joystick* joystick, int button);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RumbleJoystick(SDL_Joystick* joystick, [NativeTypeName("Uint16")] ushort low_frequency_rumble, [NativeTypeName("Uint16")] ushort high_frequency_rumble, [NativeTypeName("Uint32")] uint duration_ms);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RumbleJoystickTriggers(SDL_Joystick* joystick, [NativeTypeName("Uint16")] ushort left_rumble, [NativeTypeName("Uint16")] ushort right_rumble, [NativeTypeName("Uint32")] uint duration_ms);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetJoystickLED(SDL_Joystick* joystick, [NativeTypeName("Uint8")] byte red, [NativeTypeName("Uint8")] byte green, [NativeTypeName("Uint8")] byte blue);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SendJoystickEffect(SDL_Joystick* joystick, [NativeTypeName("const void *")] IntPtr data, int size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_CloseJoystick(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_JoystickConnectionState SDL_GetJoystickConnectionState(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_PowerState SDL_GetJoystickPowerInfo(SDL_Joystick* joystick, int* percent);

        [NativeTypeName("#define SDL_JOYSTICK_AXIS_MAX 32767")]
        public const int SDL_JOYSTICK_AXIS_MAX = 32767;

        [NativeTypeName("#define SDL_JOYSTICK_AXIS_MIN -32768")]
        public const int SDL_JOYSTICK_AXIS_MIN = -32768;

        [NativeTypeName("#define SDL_IPHONE_MAX_GFORCE 5.0")]
        public const double SDL_IPHONE_MAX_GFORCE = 5.0;

        [NativeTypeName("#define SDL_PROP_JOYSTICK_CAP_MONO_LED_BOOLEAN \"SDL.joystick.cap.mono_led\"")]
        public static ReadOnlySpan<byte> SDL_PROP_JOYSTICK_CAP_MONO_LED_BOOLEAN => "SDL.joystick.cap.mono_led"u8;

        [NativeTypeName("#define SDL_PROP_JOYSTICK_CAP_RGB_LED_BOOLEAN \"SDL.joystick.cap.rgb_led\"")]
        public static ReadOnlySpan<byte> SDL_PROP_JOYSTICK_CAP_RGB_LED_BOOLEAN => "SDL.joystick.cap.rgb_led"u8;

        [NativeTypeName("#define SDL_PROP_JOYSTICK_CAP_PLAYER_LED_BOOLEAN \"SDL.joystick.cap.player_led\"")]
        public static ReadOnlySpan<byte> SDL_PROP_JOYSTICK_CAP_PLAYER_LED_BOOLEAN => "SDL.joystick.cap.player_led"u8;

        [NativeTypeName("#define SDL_PROP_JOYSTICK_CAP_RUMBLE_BOOLEAN \"SDL.joystick.cap.rumble\"")]
        public static ReadOnlySpan<byte> SDL_PROP_JOYSTICK_CAP_RUMBLE_BOOLEAN => "SDL.joystick.cap.rumble"u8;

        [NativeTypeName("#define SDL_PROP_JOYSTICK_CAP_TRIGGER_RUMBLE_BOOLEAN \"SDL.joystick.cap.trigger_rumble\"")]
        public static ReadOnlySpan<byte> SDL_PROP_JOYSTICK_CAP_TRIGGER_RUMBLE_BOOLEAN => "SDL.joystick.cap.trigger_rumble"u8;

        [NativeTypeName("#define SDL_HAT_CENTERED 0x00u")]
        public const uint SDL_HAT_CENTERED = 0x00U;

        [NativeTypeName("#define SDL_HAT_UP 0x01u")]
        public const uint SDL_HAT_UP = 0x01U;

        [NativeTypeName("#define SDL_HAT_RIGHT 0x02u")]
        public const uint SDL_HAT_RIGHT = 0x02U;

        [NativeTypeName("#define SDL_HAT_DOWN 0x04u")]
        public const uint SDL_HAT_DOWN = 0x04U;

        [NativeTypeName("#define SDL_HAT_LEFT 0x08u")]
        public const uint SDL_HAT_LEFT = 0x08U;

        [NativeTypeName("#define SDL_HAT_RIGHTUP (SDL_HAT_RIGHT|SDL_HAT_UP)")]
        public const uint SDL_HAT_RIGHTUP = (0x02U | 0x01U);

        [NativeTypeName("#define SDL_HAT_RIGHTDOWN (SDL_HAT_RIGHT|SDL_HAT_DOWN)")]
        public const uint SDL_HAT_RIGHTDOWN = (0x02U | 0x04U);

        [NativeTypeName("#define SDL_HAT_LEFTUP (SDL_HAT_LEFT|SDL_HAT_UP)")]
        public const uint SDL_HAT_LEFTUP = (0x08U | 0x01U);

        [NativeTypeName("#define SDL_HAT_LEFTDOWN (SDL_HAT_LEFT|SDL_HAT_DOWN)")]
        public const uint SDL_HAT_LEFTDOWN = (0x08U | 0x04U);
    }
}
