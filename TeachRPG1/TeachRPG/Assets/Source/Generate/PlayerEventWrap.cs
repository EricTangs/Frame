﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class PlayerEventWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(PlayerEvent));
		L.RegVar("Initial", get_Initial, null);
		L.RegVar("JoyStickCtr", get_JoyStickCtr, null);
		L.RegVar("ReduceBlood", get_ReduceBlood, null);
		L.RegVar("NormalAttack", get_NormalAttack, null);
		L.RegVar("BigAttack", get_BigAttack, null);
		L.RegVar("StopRun", get_StopRun, null);
		L.RegVar("MaxValue", get_MaxValue, null);
		L.RegFunction("IntToEnum", IntToEnum);
		L.EndEnum();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Initial(IntPtr L)
	{
		ToLua.Push(L, PlayerEvent.Initial);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_JoyStickCtr(IntPtr L)
	{
		ToLua.Push(L, PlayerEvent.JoyStickCtr);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ReduceBlood(IntPtr L)
	{
		ToLua.Push(L, PlayerEvent.ReduceBlood);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_NormalAttack(IntPtr L)
	{
		ToLua.Push(L, PlayerEvent.NormalAttack);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_BigAttack(IntPtr L)
	{
		ToLua.Push(L, PlayerEvent.BigAttack);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_StopRun(IntPtr L)
	{
		ToLua.Push(L, PlayerEvent.StopRun);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_MaxValue(IntPtr L)
	{
		ToLua.Push(L, PlayerEvent.MaxValue);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		PlayerEvent o = (PlayerEvent)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}

