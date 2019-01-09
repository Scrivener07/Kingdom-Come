using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace KCD.Kaitai.Tables
{
	/// <summary>
	/// Provides static information about table entities.
	/// </summary>
	public static class Definition
	{
		public static bool Initialized { get; private set; }
		public static int Count { get { return Types.Count; } }
		private static Dictionary<string, Type> Types { get; set; }


		static Definition()
		{
			Types = new Dictionary<string, Type>();
		}


		public static void Initialize()
		{
			if (Initialized)
			{
				return;
			}
			else
			{
				Initialized = true;
			}

			Register(@"Data\Libs\Tables\character_beard.tbl", typeof(CharacterBeard));
			Register(@"Data\Libs\Tables\character_body.tbl", typeof(CharacterBody));
			Register(@"Data\Libs\Tables\character_hair.tbl", typeof(CharacterHair));
			Register(@"Data\Libs\Tables\character_head.tbl", typeof(CharacterHead));
			Register(@"Data\Libs\Tables\dlc.tbl", typeof(Dlc));
			Register(@"Data\Libs\Tables\editor_object_binding.tbl", typeof(EditorObjectBinding));
			Register(@"Data\Libs\Tables\editor_object.tbl", typeof(EditorObject));
			Register(@"Data\Libs\Tables\game_mode.tbl", typeof(GameMode));
			Register(@"Data\Libs\Tables\random_event_option_set.tbl", typeof(RandomEventOptionSet));
			Register(@"Data\Libs\Tables\random_event_option.tbl", typeof(RandomEventOption));
			Register(@"Data\Libs\Tables\random_event_source_type.tbl", typeof(RandomEventSourceType));
			Register(@"Data\Libs\Tables\random_event.tbl", typeof(RandomEvent));
			Register(@"Data\Libs\Tables\action\actor_action_fragment_id_mapping.tbl", typeof(ActorActionFragmentIdMapping));
			Register(@"Data\Libs\Tables\action\actor_action_standup.tbl", typeof(ActorActionStandup));
			Register(@"Data\Libs\Tables\action\actor_action_transition_to_combat.tbl", typeof(ActorActionTransitionToCombat));
			Register(@"Data\Libs\Tables\action\actor_action_type_group.tbl", typeof(ActorActionTypeGroup));
			Register(@"Data\Libs\Tables\action\actor_action_type.tbl", typeof(ActorActionType));
			Register(@"Data\Libs\Tables\action\actor_activity.tbl", typeof(ActorActivity));
			Register(@"Data\Libs\Tables\action\actor_pose.tbl", typeof(ActorPose));
			Register(@"Data\Libs\Tables\action\actor_tag_mapping.tbl", typeof(ActorTagMapping));
			Register(@"Data\Libs\Tables\ai\ai_body.tbl", typeof(AiBody));
			Register(@"Data\Libs\Tables\ai\ai_body2brain_sensor.tbl", typeof(AiBody2brainSensor));
			Register(@"Data\Libs\Tables\ai\ai_body2npc_reference_point.tbl", typeof(AiBody2npcReferencePoint));
			Register(@"Data\Libs\Tables\ai\ai_percept_handler_type.tbl", typeof(AiPerceptHandlerType));
			Register(@"Data\Libs\Tables\ai\ai_percept_handler.tbl", typeof(AiPerceptHandler));
			Register(@"Data\Libs\Tables\ai\ai_variable_form.tbl", typeof(AiVariableForm));
			Register(@"Data\Libs\Tables\ai\ai_variable_sync.tbl", typeof(AiVariableSync));
			Register(@"Data\Libs\Tables\ai\brain_interpreter_type.tbl", typeof(BrainInterpreterType));
			Register(@"Data\Libs\Tables\ai\brain_interpreter.tbl", typeof(BrainInterpreter));
			Register(@"Data\Libs\Tables\ai\brain_interpreter2brain_message_type.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\brain_message_type.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\brain_sensor_type.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\brain_sensor.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\brain_variable.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\brain.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\brain2brain_interpreter.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\brain2mailbox.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\brain2subbrain.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\mailbox_action_type.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\mailbox_filter.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\mailbox_group.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\mailbox_group2mailbox.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\mailbox.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\npc_reference_point.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\positioning_shape.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\positioning_vertex.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\sa_behaviour_action.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\sa_behaviour_tag_parent.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\sa_behaviour_tag.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\sa_behaviour_tag2mailbox.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\sa_smart_area.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\sa_smart_area2sa_behaviour_tag.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\se_condition_type.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\situation_frequency.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\situation_global_condition.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\situation_role_condition.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\situation_role_tree.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\situation_role.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\situation_role2mailbox.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\situation_variant.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\situation.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\so_behaviour_action.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\so_behaviour_state.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\so_behaviour_tag_condition.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\so_behaviour_tag_navigation.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\so_behaviour_tag_parent.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\so_behaviour_tag.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\so_behaviour_tag2mailbox.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\so_item_smart_object.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\so_smart_object.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\so_smart_object2so_behaviour_tag.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\subbrain_behaviour_tree.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\subbrain_combat.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\subbrain_dialog.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\subbrain_situation.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\subbrain_smart_area.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\subbrain_smart_object.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\subbrain_switching.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\subbrain_type.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\subbrain.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ai\subbrain2ai_percept_handler.tbl", typeof(object));
			Register(@"Data\Libs\Tables\animation\ai_fragment_exclude.tbl", typeof(object));
			Register(@"Data\Libs\Tables\animation\anim_fragment_do_not_interrupt.tbl", typeof(object));
			Register(@"Data\Libs\Tables\animation\anim_fragment_events.tbl", typeof(object));
			Register(@"Data\Libs\Tables\animation\anim_fragment.tbl", typeof(object));
			Register(@"Data\Libs\Tables\animation\hit_reaction_type.tbl", typeof(object));
			Register(@"Data\Libs\Tables\animation\hit_reaction.tbl", typeof(object));
			Register(@"Data\Libs\Tables\animation\jump.tbl", typeof(object));
			Register(@"Data\Libs\Tables\animation\ladder.tbl", typeof(object));
			Register(@"Data\Libs\Tables\animation\mn_fragment.tbl", typeof(object));
			Register(@"Data\Libs\Tables\animation\picking.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_action_attack.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_action_block_movement.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_action_block.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_action_failed_attack.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_action_fragment_id_mapping.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_action_guard_movement.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_action_guard_sync_movement.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_action_hit_movement.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_action_hit.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_action_perfect_block.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_action_pose_modifier.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_action_sync_attack.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_action_sync_hit.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_action_sync_pb_hit.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_action_sync_transition.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_action_text.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_action_trigger.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_action_type_group.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_action_type_mapping.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_action_type.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_attack_config.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_attack_hit_statistics.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_attack_type_tag.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_attack_type.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_combo_step.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_combo.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_damage_type_mapping.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_guard_stance.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_guard_type.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_hit_origin.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_hit_type.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_input_class.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_native_guard_zone.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_riposte_chain_step.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_riposte_chain.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_side.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_sync_action_hit.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_tag.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_ui_rules.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_weapon_group_to_class.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_weapon_group.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_zone_config.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_zone_distance.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_zone_mapping.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_zone_tag.tbl", typeof(object));
			Register(@"Data\Libs\Tables\combat\combat_zone.tbl", typeof(object));
			Register(@"Data\Libs\Tables\DBEntity\entity_link.tbl", typeof(object));
			Register(@"Data\Libs\Tables\DBEntity\stash.tbl", typeof(object));
			Register(@"Data\Libs\Tables\inventory\gold_dayone_stash_diff.tbl", typeof(object));
			Register(@"Data\Libs\Tables\inventory\inventories_01_03.tbl", typeof(object));
			Register(@"Data\Libs\Tables\inventory\inventories_day1patch.tbl", typeof(object));
			Register(@"Data\Libs\Tables\inventory\inventories_gold.tbl", typeof(object));
			Register(@"Data\Libs\Tables\inventory\inventories_week1patch.tbl", typeof(object));
			Register(@"Data\Libs\Tables\inventory\inventory_preset.tbl", typeof(object));
			Register(@"Data\Libs\Tables\inventory\inventory_preset2item.tbl", typeof(object));
			Register(@"Data\Libs\Tables\inventory\inventory.tbl", typeof(object));
			Register(@"Data\Libs\Tables\inventory\inventory2inventory_preset.tbl", typeof(object));
			Register(@"Data\Libs\Tables\inventory\inventory2item.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\alchemy_base.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\alchemy_material_subtype.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\alchemy_material_type.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\alchemy_material.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\ammo_class.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\ammo.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\armor_archetype.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\armor_archetype2body_subpart.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\armor_class2engine_surface.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\armor_subtype.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\armor_type.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\armor.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\armor2clothing_attachment.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\armor2clothing_preset.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\attachment_base.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\attachment_slot.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\attachment2clothing_preset.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\blood_zone.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\body_layer.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\body_material2subpart.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\body_part.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\body_subpart.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\character_head_archetype.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\clothing_attachment.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\clothing_mesh_data.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\clothing_preset.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\clothing_raycast.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\clothing.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\consumable_item.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\die.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\divisible_item.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\document_class.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\document_content_images.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\document_content.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\document_transcription_topic.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\document.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\equipment_part.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\equipment_slot.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\equippable_item.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\food_subtype.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\food_type.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\food.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\helmet.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\herb.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\item_category.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\item_manipulation_type.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\item_phase.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\item.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\key.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\keyring.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\melee_weapon_type.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\melee_weapon.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\misc_subtype.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\misc_type.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\misc.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\missile_weapon_class2ammo_class.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\missile_weapon_type.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\missile_weapon.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\npc_tool_subtype.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\npc_tool_type.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\npc_tool.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\ointment_item_subtype.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\ointment_item_type.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\ointment_item.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\pickable_area_desc.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\pickable_area_material.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\pickable_item.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\player_item.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\potion.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\questible_item.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\recipe_ingredient.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\recipe_step.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\recipe_substep.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\recipe.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\weapon_attachment_slot.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\weapon_class.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\weapon_equip_slot.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\weapon_preset.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\weapon_sub_class.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\weapon.tbl", typeof(object));
			Register(@"Data\Libs\Tables\item\weapon2weapon_preset.tbl", typeof(object));
			Register(@"Data\Libs\Tables\prefab\prefab_phase_category.tbl", typeof(object));
			Register(@"Data\Libs\Tables\prefab\prefab_phase.tbl", typeof(object));
			Register(@"Data\Libs\Tables\quest\exp_change.tbl", typeof(object));
			Register(@"Data\Libs\Tables\quest\money_change.tbl", typeof(object));
			Register(@"Data\Libs\Tables\quest\quest_asset.tbl", typeof(object));
			Register(@"Data\Libs\Tables\quest\quest_function_param.tbl", typeof(object));
			Register(@"Data\Libs\Tables\quest\quest_function.tbl", typeof(object));
			Register(@"Data\Libs\Tables\quest\quest_item.tbl", typeof(object));
			Register(@"Data\Libs\Tables\quest\quest_npc.tbl", typeof(object));
			Register(@"Data\Libs\Tables\quest\quest_objective.tbl", typeof(object));
			Register(@"Data\Libs\Tables\quest\quest_place.tbl", typeof(object));
			Register(@"Data\Libs\Tables\quest\quest_reward_achievement.tbl", typeof(object));
			Register(@"Data\Libs\Tables\quest\quest_reward_exp.tbl", typeof(object));
			Register(@"Data\Libs\Tables\quest\quest_reward_item.tbl", typeof(object));
			Register(@"Data\Libs\Tables\quest\quest_reward_money.tbl", typeof(object));
			Register(@"Data\Libs\Tables\quest\quest_reward_perk.tbl", typeof(object));
			Register(@"Data\Libs\Tables\quest\quest_reward_reputation.tbl", typeof(object));
			Register(@"Data\Libs\Tables\quest\quest_reward_script.tbl", typeof(object));
			Register(@"Data\Libs\Tables\quest\quest_soul_mortality.tbl", typeof(object));
			Register(@"Data\Libs\Tables\quest\quest_statistic.tbl", typeof(object));
			Register(@"Data\Libs\Tables\quest\quest_tracked_asset.tbl", typeof(object));
			Register(@"Data\Libs\Tables\quest\quest_transition.tbl", typeof(object));
			Register(@"Data\Libs\Tables\quest\quest_vip_npc.tbl", typeof(object));
			Register(@"Data\Libs\Tables\quest\quest.tbl", typeof(object));
			Register(@"Data\Libs\Tables\quest\quest2skald_subchapter.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\achievement_rule.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\achievement.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\angriness_enum.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\buff_class.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\buff.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\combat_shout_type.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\document_required_skill.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\document_requirement.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\document_reward_perk.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\document_reward.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\faction.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\game_over.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\gender.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\hobby.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\horse_irritation.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\location_category.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\location.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\location2perk.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\metarole.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\morale_change.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\perk_buff_override.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\perk_buff.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\perk_codex.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\perk_combo_step.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\perk_companion.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\perk_recipe.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\perk_script.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\perk_soul_ability.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\perk_special_riposte.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\perk.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\perk2perk_exclusivity.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\poi_type.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\poi_type2perk.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\race.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\reading_spot_type.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\reputation_change.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\reputation_condition.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\rich_presence.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\role.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\rpg_movement_type.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\rpg_param.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\rpg_sound.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\skill_check_difficulty.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\skill.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\skill2item_category.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\sleeping_spot_type.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\social_class.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\soul_archetype_movement.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\soul_archetype.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\soul_class.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\soul_slot2health.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\soul_slot2weapon_health.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\soul.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\soul2hobby.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\soul2inventory.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\soul2metarole.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\soul2perk.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\soul2skill.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\sph_group.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\sph_highlight.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\statistic_group.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\statistic.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\superfaction.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\superfaction2superfaction_relationship.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\v_rich_presence_text.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\v_soul_character_data.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\v_soul2role_metarole.tbl", typeof(object));
			Register(@"Data\Libs\Tables\rpg\v_sph_texts.tbl", typeof(object));
			Register(@"Data\Libs\Tables\shop\shop_type2item.tbl", typeof(object));
			Register(@"Data\Libs\Tables\shop\shop.tbl", typeof(object));
			Register(@"Data\Libs\Tables\shop\shop2item.tbl", typeof(object));
			Register(@"Data\Libs\Tables\shop\shopkeeper.tbl", typeof(object));
			Register(@"Data\Libs\Tables\skald\skald_objective_string_type.tbl", typeof(object));
			Register(@"Data\Libs\Tables\skald\skald_objective_string.tbl", typeof(object));
			Register(@"Data\Libs\Tables\skald\skald_objective.tbl", typeof(object));
			Register(@"Data\Libs\Tables\skald\skald_quest_string_type.tbl", typeof(object));
			Register(@"Data\Libs\Tables\skald\skald_quest_string.tbl", typeof(object));
			Register(@"Data\Libs\Tables\text\dialogue_functions.tbl", typeof(object));
			Register(@"Data\Libs\Tables\text\dialogue_hearing.tbl", typeof(object));
			Register(@"Data\Libs\Tables\text\dialogue_mood.tbl", typeof(object));
			Register(@"Data\Libs\Tables\text\response.tbl", typeof(object));
			Register(@"Data\Libs\Tables\text\sequence_flowchart.tbl", typeof(object));
			Register(@"Data\Libs\Tables\text\sequence_line.tbl", typeof(object));
			Register(@"Data\Libs\Tables\text\sequence.tbl", typeof(object));
			Register(@"Data\Libs\Tables\text\sequence2quest_objective.tbl", typeof(object));
			Register(@"Data\Libs\Tables\text\topic.tbl", typeof(object));
			Register(@"Data\Libs\Tables\text\topic2sequence.tbl", typeof(object));
			Register(@"Data\Libs\Tables\text\topictorole.tbl", typeof(object));
			Register(@"Data\Libs\Tables\text\v_branch.tbl", typeof(object));
			Register(@"Data\Libs\Tables\text\v_dialogue_commands.tbl", typeof(object));
			Register(@"Data\Libs\Tables\text\v_response_wave_file_recorded.tbl", typeof(object));
			Register(@"Data\Libs\Tables\text\v_topic2subchapter_id.tbl", typeof(object));
			Register(@"Data\Libs\Tables\text\v_voice_abbreviation.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ui\cf_backer_ingame.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ui\credit_layout.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ui\credit_people.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ui\credit_role.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ui\credit_role2language.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ui\infotext_category.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ui\skiptime.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ui\ui_local_maps.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ui\ui_map_label.tbl", typeof(object));
			Register(@"Data\Libs\Tables\ui\video_language2audio_track.tbl", typeof(object));

			Trace.WriteLine("Initialized with " + Count + " definitions.");
		}


		/// <summary>
		/// Registers the given filename with the given System.Type.
		/// </summary>
		/// <param name="filename">The file name and extension to use. A path may also be passed in.</param>
		/// <param name="type">The system type to associate.</param>
		/// <returns>Returns true on success.</returns>
		private static bool Register(string filename, Type type)
		{
			filename = Path.GetFileName(filename);
			if (!Types.ContainsKey(filename))
			{
				Types.Add(filename, type);
				if (type == null)
				{
					Trace.WriteLine(string.Format("Registered the {0} key with no type.", filename, type));
				}
				else
				{
					Trace.WriteLine(string.Format("Registered the {0} key with the {1} type.", filename, type));
				}

				return true;
			}
			else
			{
				Trace.WriteLine(string.Format("Failed to register the {0} key with the {1} type.", filename, type));
				return false;
			}
		}


		public static Type GetType(string key)
		{
			return Types[key];
		}


		public static bool Exists(string key)
		{
			return Types.ContainsKey(key);
		}


	}
}
