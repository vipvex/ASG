// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UniRx;


[DiagramInfoAttribute("Ultimate Strategy Game")]
public abstract class ChunkViewBase : ViewBase {
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Int32 _ChunkX;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Int32 _ChunkY;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Int32 _TerrainDataX;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Int32 _TerrainDataY;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Vector3 _WorldPos;
    
    public override System.Type ViewModelType {
        get {
            return typeof(ChunkViewModel);
        }
    }
    
    public ChunkViewModel Chunk {
        get {
            return ((ChunkViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<ChunkController>());
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        ChunkViewModel chunk = ((ChunkViewModel)(viewModel));
        chunk.ChunkX = this._ChunkX;
        chunk.ChunkY = this._ChunkY;
        chunk.TerrainDataX = this._TerrainDataX;
        chunk.TerrainDataY = this._TerrainDataY;
        chunk.WorldPos = this._WorldPos;
    }
    
    public virtual void ExecuteGenerateChunk() {
        this.ExecuteCommand(Chunk.GenerateChunk);
    }
    
    public virtual void ExecuteUpdateChunk() {
        this.ExecuteCommand(Chunk.UpdateChunk);
    }
    
    public virtual void ExecuteSaveChunkHexTexture() {
        this.ExecuteCommand(Chunk.SaveChunkHexTexture);
    }
}

[DiagramInfoAttribute("Ultimate Strategy Game")]
public abstract class TerrainManagerViewBase : ViewBase {
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Int32 _TerrainSeed;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Boolean _RandomizeSeed;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Int32 _PixelsPerUnit;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Single _PixelToHeight;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Single _Altitudes;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Int32 _ChunkSize;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Int32 _ChunkResolution;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Int32 _ChunkCollisionResolution;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Int32 _TerrainWidth;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Int32 _TerrainHeight;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Single _Detail;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Single _AltitudeVariation;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Int32 _HexagonSide;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Int32 _RiverCount;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Single _MinRiverHeight;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Int32 _MinRiverStrength;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Int32 _MaxRiverStrength;
    
    public override string DefaultIdentifier {
        get {
            return "TerrainManager";
        }
    }
    
    public override System.Type ViewModelType {
        get {
            return typeof(TerrainManagerViewModel);
        }
    }
    
    public TerrainManagerViewModel TerrainManager {
        get {
            return ((TerrainManagerViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<TerrainManagerController>());
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        TerrainManagerViewModel terrainManager = ((TerrainManagerViewModel)(viewModel));
        terrainManager.TerrainSeed = this._TerrainSeed;
        terrainManager.RandomizeSeed = this._RandomizeSeed;
        terrainManager.PixelsPerUnit = this._PixelsPerUnit;
        terrainManager.PixelToHeight = this._PixelToHeight;
        terrainManager.Altitudes = this._Altitudes;
        terrainManager.ChunkSize = this._ChunkSize;
        terrainManager.ChunkResolution = this._ChunkResolution;
        terrainManager.ChunkCollisionResolution = this._ChunkCollisionResolution;
        terrainManager.TerrainWidth = this._TerrainWidth;
        terrainManager.TerrainHeight = this._TerrainHeight;
        terrainManager.Detail = this._Detail;
        terrainManager.AltitudeVariation = this._AltitudeVariation;
        terrainManager.HexagonSide = this._HexagonSide;
        terrainManager.RiverCount = this._RiverCount;
        terrainManager.MinRiverHeight = this._MinRiverHeight;
        terrainManager.MinRiverStrength = this._MinRiverStrength;
        terrainManager.MaxRiverStrength = this._MaxRiverStrength;
    }
    
    public virtual void ExecuteGenerateMap() {
        this.ExecuteCommand(TerrainManager.GenerateMap);
    }
    
    public virtual void ExecuteGenerateChunks() {
        this.ExecuteCommand(TerrainManager.GenerateChunks);
    }
    
    public virtual void ExecuteGetHexAtWorldPos(Vector3 arg) {
        this.ExecuteCommand(TerrainManager.GetHexAtWorldPos, arg);
    }
}

[DiagramInfoAttribute("Ultimate Strategy Game")]
public abstract class WorldManagerViewBase : ViewBase {
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public ViewBase _TerrainManager;
    
    public override System.Type ViewModelType {
        get {
            return typeof(WorldManagerViewModel);
        }
    }
    
    public WorldManagerViewModel WorldManager {
        get {
            return ((WorldManagerViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<WorldManagerController>());
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        WorldManagerViewModel worldManager = ((WorldManagerViewModel)(viewModel));
        worldManager.TerrainManager = this._TerrainManager == null ? null : this._TerrainManager.ViewModelObject as TerrainManagerViewModel;
    }
}

[DiagramInfoAttribute("Ultimate Strategy Game")]
public abstract class AStarViewBase : ViewBase {
    
    public override System.Type ViewModelType {
        get {
            return typeof(AStarViewModel);
        }
    }
    
    public AStarViewModel AStar {
        get {
            return ((AStarViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<AStarController>());
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
    }
}

[DiagramInfoAttribute("Ultimate Strategy Game")]
public abstract class GameLogicViewBase : ViewBase {
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Int32 _PlayerCount;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Int32 _TurnCount;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public ViewBase _CurrentPlayer;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public ViewBase _HumanPlayer;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public ViewBase _TerrainManager;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public GameState _GameState;
    
    public override System.Type ViewModelType {
        get {
            return typeof(GameLogicViewModel);
        }
    }
    
    public GameLogicViewModel GameLogic {
        get {
            return ((GameLogicViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<GameLogicController>());
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        GameLogicViewModel gameLogic = ((GameLogicViewModel)(viewModel));
        gameLogic.PlayerCount = this._PlayerCount;
        gameLogic.TurnCount = this._TurnCount;
        gameLogic.CurrentPlayer = this._CurrentPlayer == null ? null : this._CurrentPlayer.ViewModelObject as PlayerViewModel;
        gameLogic.HumanPlayer = this._HumanPlayer == null ? null : this._HumanPlayer.ViewModelObject as PlayerViewModel;
        gameLogic.TerrainManager = this._TerrainManager == null ? null : this._TerrainManager.ViewModelObject as TerrainManagerViewModel;
        gameLogic.GameState = this._GameState;
    }
    
    public virtual void ExecuteStartGame() {
        this.ExecuteCommand(GameLogic.StartGame);
    }
    
    public virtual void ExecuteSetupPlayers() {
        this.ExecuteCommand(GameLogic.SetupPlayers);
    }
    
    public virtual void ExecuteNextTurn() {
        this.ExecuteCommand(GameLogic.NextTurn);
    }
}

[DiagramInfoAttribute("Ultimate Strategy Game")]
public abstract class PlayerViewBase : ViewBase {
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public String _Name;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Boolean _IsHuman;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public ViewBase _SelectedUnit;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public ViewBase _Faction;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Color _Color;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Boolean _MovingUnit;
    
    public override System.Type ViewModelType {
        get {
            return typeof(PlayerViewModel);
        }
    }
    
    public PlayerViewModel Player {
        get {
            return ((PlayerViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<PlayerController>());
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        PlayerViewModel player = ((PlayerViewModel)(viewModel));
        player.Name = this._Name;
        player.IsHuman = this._IsHuman;
        player.SelectedUnit = this._SelectedUnit == null ? null : this._SelectedUnit.ViewModelObject as UnitViewModel;
        player.Faction = this._Faction == null ? null : this._Faction.ViewModelObject as FactionViewModel;
        player.Color = this._Color;
        player.MovingUnit = this._MovingUnit;
    }
    
    public virtual void ExecuteSelectHex(Hex arg) {
        this.ExecuteCommand(Player.SelectHex, arg);
    }
    
    public virtual void ExecuteSelectUnit(UnitViewModel unit) {
        this.ExecuteCommand(Player.SelectUnit, unit);
    }
    
    public virtual void ExecuteMoveUnit(UnitViewModel unit) {
        this.ExecuteCommand(Player.MoveUnit, unit);
    }
    
    public virtual void ExecuteGetHexAtWorldPos(Vector3 arg) {
        this.ExecuteCommand(Player.GetHexAtWorldPos, arg);
    }
}

[DiagramInfoAttribute("Ultimate Strategy Game")]
public abstract class UnitViewBase : ViewBase {
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public String _Name;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Int32 _Health;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Int32 _MaxHealth;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Int32 _MovementRange;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public String _State;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public String _IsSelected;
    
    public override System.Type ViewModelType {
        get {
            return typeof(UnitViewModel);
        }
    }
    
    public UnitViewModel Unit {
        get {
            return ((UnitViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<UnitController>());
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        UnitViewModel unit = ((UnitViewModel)(viewModel));
        unit.Name = this._Name;
        unit.Health = this._Health;
        unit.MaxHealth = this._MaxHealth;
        unit.MovementRange = this._MovementRange;
        unit.State = this._State;
        unit.IsSelected = this._IsSelected;
    }
    
    public virtual void ExecuteMove(Hex arg) {
        this.ExecuteCommand(Unit.Move, arg);
    }
    
    public virtual void ExecuteCancelMove() {
        this.ExecuteCommand(Unit.CancelMove);
    }
}

[DiagramInfoAttribute("Ultimate Strategy Game")]
public abstract class FactionViewBase : ViewBase {
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public String _Name;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Single _Food;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Single _Gold;
    
    public override System.Type ViewModelType {
        get {
            return typeof(FactionViewModel);
        }
    }
    
    public FactionViewModel Faction {
        get {
            return ((FactionViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<FactionController>());
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        FactionViewModel faction = ((FactionViewModel)(viewModel));
        faction.Name = this._Name;
        faction.Food = this._Food;
        faction.Gold = this._Gold;
    }
}

[DiagramInfoAttribute("Ultimate Strategy Game")]
public abstract class CityViewBase : ViewBase {
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public String _Name;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Int32 _Population;
    
    public override System.Type ViewModelType {
        get {
            return typeof(CityViewModel);
        }
    }
    
    public CityViewModel City {
        get {
            return ((CityViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<CityController>());
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        CityViewModel city = ((CityViewModel)(viewModel));
        city.Name = this._Name;
        city.Population = this._Population;
    }
}

[DiagramInfoAttribute("Ultimate Strategy Game")]
public abstract class BuildingViewBase : ViewBase {
    
    public override System.Type ViewModelType {
        get {
            return typeof(BuildingViewModel);
        }
    }
    
    public BuildingViewModel Building {
        get {
            return ((BuildingViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<BuildingController>());
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
    }
}

[DiagramInfoAttribute("Ultimate Strategy Game")]
public abstract class TerrainElementViewBase : ViewBase {
    
    public override System.Type ViewModelType {
        get {
            return typeof(TerrainElementViewModel);
        }
    }
    
    public TerrainElementViewModel TerrainElement {
        get {
            return ((TerrainElementViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<TerrainElementController>());
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
    }
}

[DiagramInfoAttribute("Ultimate Strategy Game")]
public abstract class AIPlayerViewBase : PlayerViewBase {
    
    public override System.Type ViewModelType {
        get {
            return typeof(AIPlayerViewModel);
        }
    }
    
    public AIPlayerViewModel AIPlayer {
        get {
            return ((AIPlayerViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<AIPlayerController>());
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        base.InitializeViewModel(viewModel);
    }
    
    public virtual void ExecuteThink() {
        this.ExecuteCommand(AIPlayer.Think);
    }
}

[DiagramInfoAttribute("Ultimate Strategy Game")]
public abstract class SettlerUnitViewBase : UnitViewBase {
    
    public override System.Type ViewModelType {
        get {
            return typeof(SettlerUnitViewModel);
        }
    }
    
    public SettlerUnitViewModel SettlerUnit {
        get {
            return ((SettlerUnitViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<SettlerUnitController>());
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        base.InitializeViewModel(viewModel);
    }
}

[DiagramInfoAttribute("Ultimate Strategy Game")]
public abstract class CombatUnitViewBase : UnitViewBase {
    
    public override System.Type ViewModelType {
        get {
            return typeof(CombatUnitViewModel);
        }
    }
    
    public CombatUnitViewModel CombatUnit {
        get {
            return ((CombatUnitViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<CombatUnitController>());
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        base.InitializeViewModel(viewModel);
    }
}

public class ChunkViewViewBase : ChunkViewBase {
    
    [UFToggleGroup("GenerateChunk")]
    [UnityEngine.HideInInspector()]
    public bool _BindGenerateChunk = true;
    
    [UFToggleGroup("SaveChunkHexTexture")]
    [UnityEngine.HideInInspector()]
    public bool _BindSaveChunkHexTexture = true;
    
    [UFToggleGroup("UpdateChunk")]
    [UnityEngine.HideInInspector()]
    public bool _BindUpdateChunk = true;
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<ChunkController>());
    }
    
    /// Invokes GenerateChunkExecuted when the GenerateChunk command is executed.
    public virtual void GenerateChunkExecuted() {
    }
    
    /// Invokes SaveChunkHexTextureExecuted when the SaveChunkHexTexture command is executed.
    public virtual void SaveChunkHexTextureExecuted() {
    }
    
    /// Invokes UpdateChunkExecuted when the UpdateChunk command is executed.
    public virtual void UpdateChunkExecuted() {
    }
    
    public override void Bind() {
        base.Bind();
        if (this._BindGenerateChunk) {
            this.BindCommandExecuted(Chunk.GenerateChunk, GenerateChunkExecuted);
        }
        if (this._BindSaveChunkHexTexture) {
            this.BindCommandExecuted(Chunk.SaveChunkHexTexture, SaveChunkHexTextureExecuted);
        }
        if (this._BindUpdateChunk) {
            this.BindCommandExecuted(Chunk.UpdateChunk, UpdateChunkExecuted);
        }
    }
}

public partial class ChunkView : ChunkViewViewBase {
}

public class TerrainManagerViewViewBase : TerrainManagerViewBase {
    
    [UFToggleGroup("GenerateMap")]
    [UnityEngine.HideInInspector()]
    public bool _BindGenerateMap = true;
    
    [UFToggleGroup("GenerateChunks")]
    [UnityEngine.HideInInspector()]
    public bool _BindGenerateChunks = true;
    
    [UFToggleGroup("Chunks")]
    [UnityEngine.HideInInspector()]
    public bool _BindChunks = true;
    
    [UFGroup("Chunks")]
    [UnityEngine.HideInInspector()]
    public bool _ChunksSceneFirst;
    
    [UFGroup("Chunks")]
    [UnityEngine.HideInInspector()]
    public UnityEngine.Transform _ChunksContainer;
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<TerrainManagerController>());
    }
    
    /// Invokes GenerateMapExecuted when the GenerateMap command is executed.
    public virtual void GenerateMapExecuted() {
    }
    
    /// Invokes GenerateChunksExecuted when the GenerateChunks command is executed.
    public virtual void GenerateChunksExecuted() {
    }
    
    /// This binding will add or remove views based on an element/viewmodel collection.
    public virtual ViewBase CreateChunksView(ChunkViewModel item) {
        return this.InstantiateView(item);
    }
    
    /// This binding will add or remove views based on an element/viewmodel collection.
    public virtual void ChunksAdded(ViewBase item) {
    }
    
    /// This binding will add or remove views based on an element/viewmodel collection.
    public virtual void ChunksRemoved(ViewBase item) {
    }
    
    public override void Bind() {
        base.Bind();
        if (this._BindGenerateMap) {
            this.BindCommandExecuted(TerrainManager.GenerateMap, GenerateMapExecuted);
        }
        if (this._BindGenerateChunks) {
            this.BindCommandExecuted(TerrainManager.GenerateChunks, GenerateChunksExecuted);
        }
        if (this._BindChunks) {
            this.BindToViewCollection( TerrainManager._ChunksProperty, viewModel=>{ return CreateChunksView(viewModel as ChunkViewModel); }, ChunksAdded, ChunksRemoved, _ChunksContainer, _ChunksSceneFirst);
        }
    }
}

public partial class TerrainManagerView : TerrainManagerViewViewBase {
}

public class GameLogicGUIViewBase : GameLogicViewBase {
    
    [UFToggleGroup("TurnCount")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("TurnCountChanged")]
    public bool _BindTurnCount = true;
    
    [UFToggleGroup("NextTurn")]
    [UnityEngine.HideInInspector()]
    public bool _BindNextTurn = true;
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<GameLogicController>());
    }
    
    /// Subscribes to the property and is notified anytime the value changes.
    public virtual void TurnCountChanged(Int32 value) {
    }
    
    /// Invokes NextTurnExecuted when the NextTurn command is executed.
    public virtual void NextTurnExecuted() {
    }
    
    public override void Bind() {
        base.Bind();
        if (this._BindTurnCount) {
            this.BindProperty(GameLogic._TurnCountProperty, this.TurnCountChanged);
        }
        if (this._BindNextTurn) {
            this.BindCommandExecuted(GameLogic.NextTurn, NextTurnExecuted);
        }
    }
}

public partial class GameLogicGUI : GameLogicGUIViewBase {
}

public class PlayerViewViewBase : PlayerViewBase {
    
    [UFToggleGroup("SelectedUnit")]
    [UnityEngine.HideInInspector()]
    public bool _BindSelectedUnit = true;
    
    [UFToggleGroup("SelectedHex")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("SelectedHexChanged")]
    public bool _BindSelectedHex = true;
    
    [UFToggleGroup("MovingUnit")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("MovingUnitChanged")]
    public bool _BindMovingUnit = true;
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<PlayerController>());
    }
    
    /// Subscribes to the property and is notified anytime the value changes.
    public virtual void SelectedUnitChanged(UnitViewModel value) {
    }
    
    /// Subscribes to the property and is notified anytime the value changes.
    public virtual void SelectedHexChanged(Hex value) {
    }
    
    /// Subscribes to the property and is notified anytime the value changes.
    public virtual void MovingUnitChanged(Boolean value) {
    }
    
    public override void Bind() {
        base.Bind();
        if (this._BindSelectedUnit) {
            this.BindProperty(Player._SelectedUnitProperty, this.SelectedUnitChanged);
        }
        if (this._BindSelectedHex) {
            this.BindProperty(Player._SelectedHexProperty, this.SelectedHexChanged);
        }
        if (this._BindMovingUnit) {
            this.BindProperty(Player._MovingUnitProperty, this.MovingUnitChanged);
        }
    }
}

public partial class PlayerView : PlayerViewViewBase {
}

public class PlayerHUDViewViewBase : PlayerViewBase {
    
    [UFToggleGroup("SelectedHex")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("SelectedHexChanged")]
    public bool _BindSelectedHex = true;
    
    [UFToggleGroup("SelectedUnit")]
    [UnityEngine.HideInInspector()]
    public bool _BindSelectedUnit = true;
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<PlayerController>());
    }
    
    /// Subscribes to the property and is notified anytime the value changes.
    public virtual void SelectedHexChanged(Hex value) {
    }
    
    /// Subscribes to the property and is notified anytime the value changes.
    public virtual void SelectedUnitChanged(UnitViewModel value) {
    }
    
    public override void Bind() {
        base.Bind();
        if (this._BindSelectedHex) {
            this.BindProperty(Player._SelectedHexProperty, this.SelectedHexChanged);
        }
        if (this._BindSelectedUnit) {
            this.BindProperty(Player._SelectedUnitProperty, this.SelectedUnitChanged);
        }
    }
}

public partial class PlayerHUDView : PlayerHUDViewViewBase {
}

public class FactionViewViewBase : FactionViewBase {
    
    [UFToggleGroup("Units")]
    [UnityEngine.HideInInspector()]
    public bool _BindUnits = true;
    
    [UFGroup("Units")]
    [UnityEngine.HideInInspector()]
    public bool _UnitsSceneFirst;
    
    [UFGroup("Units")]
    [UnityEngine.HideInInspector()]
    public UnityEngine.Transform _UnitsContainer;
    
    [UFToggleGroup("Cities")]
    [UnityEngine.HideInInspector()]
    public bool _BindCities = true;
    
    [UFGroup("Cities")]
    [UnityEngine.HideInInspector()]
    public bool _CitiesSceneFirst;
    
    [UFGroup("Cities")]
    [UnityEngine.HideInInspector()]
    public UnityEngine.Transform _CitiesContainer;
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<FactionController>());
    }
    
    /// This binding will add or remove views based on an element/viewmodel collection.
    public virtual ViewBase CreateUnitsView(UnitViewModel item) {
        return this.InstantiateView(item);
    }
    
    /// This binding will add or remove views based on an element/viewmodel collection.
    public virtual void UnitsAdded(ViewBase item) {
    }
    
    /// This binding will add or remove views based on an element/viewmodel collection.
    public virtual void UnitsRemoved(ViewBase item) {
    }
    
    /// This binding will add or remove views based on an element/viewmodel collection.
    public virtual ViewBase CreateCitiesView(CityViewModel item) {
        return this.InstantiateView(item);
    }
    
    /// This binding will add or remove views based on an element/viewmodel collection.
    public virtual void CitiesAdded(ViewBase item) {
    }
    
    /// This binding will add or remove views based on an element/viewmodel collection.
    public virtual void CitiesRemoved(ViewBase item) {
    }
    
    public override void Bind() {
        base.Bind();
        if (this._BindUnits) {
            this.BindToViewCollection( Faction._UnitsProperty, viewModel=>{ return CreateUnitsView(viewModel as UnitViewModel); }, UnitsAdded, UnitsRemoved, _UnitsContainer, _UnitsSceneFirst);
        }
        if (this._BindCities) {
            this.BindToViewCollection( Faction._CitiesProperty, viewModel=>{ return CreateCitiesView(viewModel as CityViewModel); }, CitiesAdded, CitiesRemoved, _CitiesContainer, _CitiesSceneFirst);
        }
    }
}

public partial class FactionView : FactionViewViewBase {
}

public class GameLogicViewViewBase : GameLogicViewBase {
    
    [UFToggleGroup("Players")]
    [UnityEngine.HideInInspector()]
    public bool _BindPlayers = true;
    
    [UFGroup("Players")]
    [UnityEngine.HideInInspector()]
    public bool _PlayersSceneFirst;
    
    [UFGroup("Players")]
    [UnityEngine.HideInInspector()]
    public UnityEngine.Transform _PlayersContainer;
    
    [UFToggleGroup("Factions")]
    [UnityEngine.HideInInspector()]
    public bool _BindFactions = true;
    
    [UFGroup("Factions")]
    [UnityEngine.HideInInspector()]
    public bool _FactionsSceneFirst;
    
    [UFGroup("Factions")]
    [UnityEngine.HideInInspector()]
    public UnityEngine.Transform _FactionsContainer;
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<GameLogicController>());
    }
    
    /// This binding will add or remove views based on an element/viewmodel collection.
    public virtual ViewBase CreatePlayersView(PlayerViewModel item) {
        return this.InstantiateView(item);
    }
    
    /// This binding will add or remove views based on an element/viewmodel collection.
    public virtual void PlayersAdded(ViewBase item) {
    }
    
    /// This binding will add or remove views based on an element/viewmodel collection.
    public virtual void PlayersRemoved(ViewBase item) {
    }
    
    /// This binding will add or remove views based on an element/viewmodel collection.
    public virtual ViewBase CreateFactionsView(FactionViewModel item) {
        return this.InstantiateView(item);
    }
    
    /// This binding will add or remove views based on an element/viewmodel collection.
    public virtual void FactionsAdded(ViewBase item) {
    }
    
    /// This binding will add or remove views based on an element/viewmodel collection.
    public virtual void FactionsRemoved(ViewBase item) {
    }
    
    public override void Bind() {
        base.Bind();
        if (this._BindPlayers) {
            this.BindToViewCollection( GameLogic._PlayersProperty, viewModel=>{ return CreatePlayersView(viewModel as PlayerViewModel); }, PlayersAdded, PlayersRemoved, _PlayersContainer, _PlayersSceneFirst);
        }
        if (this._BindFactions) {
            this.BindToViewCollection( GameLogic._FactionsProperty, viewModel=>{ return CreateFactionsView(viewModel as FactionViewModel); }, FactionsAdded, FactionsRemoved, _FactionsContainer, _FactionsSceneFirst);
        }
    }
}

public partial class GameLogicView : GameLogicViewViewBase {
}

public class UnitViewViewBase : UnitViewBase {
    
    [UFToggleGroup("Move")]
    [UnityEngine.HideInInspector()]
    public bool _BindMove = true;
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<UnitController>());
    }
    
    /// Invokes MoveExecuted when the Move command is executed.
    public virtual void MoveExecuted() {
    }
    
    public override void Bind() {
        base.Bind();
        if (this._BindMove) {
            this.BindCommandExecuted(Unit.Move, MoveExecuted);
        }
    }
}

public partial class UnitView : UnitViewViewBase {
}

public class SettlerUnitViewViewBase : UnitView {
    
    public SettlerUnitViewModel SettlerUnit {
        get {
            return ((SettlerUnitViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public override System.Type ViewModelType {
        get {
            return typeof(SettlerUnitViewModel);
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<SettlerUnitController>());
    }
    
    public override void Bind() {
        base.Bind();
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        base.InitializeViewModel(viewModel);
    }
}

public partial class SettlerUnitView : SettlerUnitViewViewBase {
}
